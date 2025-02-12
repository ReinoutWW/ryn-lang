using Antlr4.Runtime;
using Ryn.AST;
using Ryn.CodeGen;

namespace Ryn.Compiler
{
    public class Compiler
    {
        public void CompileAndRun(string source)
        {
            var lexer = new RynLexer(CharStreams.fromString(source));
            var tokens = new CommonTokenStream(lexer);
            var parser = new RynParser(tokens);
            var parseTree = parser.program();

            var visitor = new RynAstBuilder();
            ProgramNode ast = visitor.VisitProgram(parseTree);

            RynAstToCSharpVisitor rynAstToCSharpVisitor = new RynAstToCSharpVisitor();
            var roslynAst = rynAstToCSharpVisitor.Visit(ast);

            var roslynCompiler = new RoslynCompiler();
            roslynCompiler.CompileAndRun(roslynAst);
        }
    }
}
