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
            var compilation = CSharpCompilation.Create("Generated")
                .WithOptions(new CSharpCompilationOptions(OutputKind.ConsoleApplication))
                .AddSyntaxTrees(SyntaxFactory.SyntaxTree(syntaxTree));

            using var ms = new MemoryStream();
            compilation.Emit(ms);
            ms.Seek(0, SeekOrigin.Begin);
            var assembly = Assembly.Load(ms.ToArray());
            assembly.EntryPoint?.Invoke(null, null);
        }
    }

}
