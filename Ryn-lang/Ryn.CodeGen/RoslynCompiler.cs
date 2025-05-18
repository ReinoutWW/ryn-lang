using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ryn.CodeGen
{
    public class RoslynCompiler
    {
        public void CompileAndRun(CompilationUnitSyntax syntaxTree)
        {
            // Basic metadata references so Roslyn can compile a runnable assembly
            var references = new[]
            {
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(Console).Assembly.Location)
            };

            var compilation = CSharpCompilation.Create("Generated")
                .WithOptions(new CSharpCompilationOptions(OutputKind.ConsoleApplication))
                .AddReferences(references)
                .AddSyntaxTrees(SyntaxFactory.SyntaxTree(syntaxTree));

            using var ms = new MemoryStream();
            var emitResult = compilation.Emit(ms);
            if (!emitResult.Success)
            {
                var message = string.Join("\n", emitResult.Diagnostics.Select(d => d.ToString()));
                throw new InvalidOperationException($"Compilation failed:\n{message}");
            }
            ms.Seek(0, SeekOrigin.Begin);
            var assembly = Assembly.Load(ms.ToArray());
            assembly.EntryPoint?.Invoke(null, null);
        }
    }

}
