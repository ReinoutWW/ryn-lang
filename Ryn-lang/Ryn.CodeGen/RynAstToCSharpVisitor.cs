using Microsoft.CodeAnalysis.CSharp;
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
            var classDecl = SyntaxFactory.ClassDeclaration(node.Name)
                .AddModifiers(ToModifier(node.AccessModifier));

            var methods = node.Methods.Select(VisitMethod).ToArray();
            return classDecl.AddMembers(methods);
        }

        private MemberDeclarationSyntax VisitMethod(MethodNode node)
        {
            var method = SyntaxFactory.MethodDeclaration(
                    SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.VoidKeyword)),
                    node.Name)
                .AddModifiers(ToModifier(node.AccessModifier))
                .WithBody(SyntaxFactory.Block(node.Body.Select(VisitStatement)));
            return method;
        }

        private StatementSyntax VisitStatement(AstNode node) => node switch
        {
            PrintNode print => SyntaxFactory.ExpressionStatement(
                SyntaxFactory.InvocationExpression(
                    SyntaxFactory.MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        SyntaxFactory.IdentifierName("Console"),
                        SyntaxFactory.IdentifierName("WriteLine")))
                    .WithArgumentList(
                        SyntaxFactory.ArgumentList(
                            SyntaxFactory.SingletonSeparatedList(
                                SyntaxFactory.Argument(SyntaxFactory.ParseExpression(print.Content)))))),
            _ => SyntaxFactory.EmptyStatement()
        };

        private static SyntaxToken ToModifier(string mod) => mod switch
        {
            "pub" => SyntaxFactory.Token(SyntaxKind.PublicKeyword),
            "priv" => SyntaxFactory.Token(SyntaxKind.PrivateKeyword),
            "prot" => SyntaxFactory.Token(SyntaxKind.ProtectedKeyword),
            _ => SyntaxFactory.Token(SyntaxKind.PublicKeyword)
        };
    }

}
