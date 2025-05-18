using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryn.AST
{
    // 1) AST Node Classes
    public abstract class AstNode { }

    public class ProgramNode : AstNode
    {
        public List<ClassNode> Classes { get; } = new List<ClassNode>();
    }

    public class ClassNode : AstNode
    {
        public string AccessModifier { get; }
        public string Name { get; }
        public List<MethodNode> Methods { get; } = new List<MethodNode>();
        public ClassNode(string mod, string name)
        {
            AccessModifier = mod;
            Name = name;
        }
    }

    public class MethodNode : AstNode
    {
        public string AccessModifier { get; }
        public string Name { get; }
        public List<AstNode> Body { get; } = new List<AstNode>();
        public MethodNode(string mod, string name)
        {
            AccessModifier = mod;
            Name = name;
        }
    }

    public class PrintNode : AstNode
    {
        public string Content { get; }
        public PrintNode(string content) => Content = content;
    }

    public class VarDeclNode : AstNode
    {
        public string Name { get; }
        public string Expression { get; }

        public VarDeclNode(string name, string expression)
        {
            Name = name;
            Expression = expression;
        }
    }
}
