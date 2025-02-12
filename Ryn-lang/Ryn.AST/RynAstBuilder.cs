using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryn.AST
{
    public class RynAstBuilder : RynBaseVisitor<AstNode>
    {
        public override ProgramNode VisitProgram(RynParser.ProgramContext context)
        {
            var root = new ProgramNode();
            foreach (var c in context.classDecl())
            {
                var classNode = VisitClassDecl(c);
                root.Classes.Add((ClassNode)classNode);
            }
            return root;
        }

        public override AstNode VisitClassDecl(RynParser.ClassDeclContext context)
        {
            string mod = context.accessModifier().GetText();
            string name = context.ID().GetText();
            var classNode = new ClassNode(mod, name);
            foreach (var m in context.methodDecl())
            {
                var methodNode = VisitMethodDecl(m);
                classNode.Methods.Add((MethodNode)methodNode);
            }
            return classNode;
        }

        public override AstNode VisitMethodDecl(RynParser.MethodDeclContext context)
        {
            string mod = context.accessModifier().GetText();
            string name = context.ID().GetText();
            var methodNode = new MethodNode(mod, name);
            foreach (var stmt in context.statement())
            {
                var stmtNode = Visit(stmt);
                methodNode.Body.Add(stmtNode);
            }
            return methodNode;
        }

        public override AstNode VisitPrintStmt(RynParser.PrintStmtContext ctx)
        {
            string content = ctx.expr().GetText();
            return new PrintNode(content);
        }
    }
}
