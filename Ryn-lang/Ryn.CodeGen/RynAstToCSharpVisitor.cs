using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Ryn.AST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryn.CodeGen
{
    public class RynAstToCSharpVisitor
    {
        public CompilationUnitSyntax Visit(ProgramNode programNode)
        {
            return SyntaxFactory.CompilationUnit()
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System")))
                .AddMembers(programNode.Classes.Select(VisitClass).ToArray());
        }

        private ClassDeclarationSyntax VisitClass(ClassNode node)
        {
            return SyntaxFactory.ClassDeclaration(node.Name)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));
        }
    }

}
