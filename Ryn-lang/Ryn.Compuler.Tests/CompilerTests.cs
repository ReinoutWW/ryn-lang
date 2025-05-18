using System;
using System.IO;
using Xunit;

namespace Ryn.Compuler.Tests
{
    public class CompilerTests
    {
        [Fact]
        public void VarDecl_Should_Print_Value()
        {
            var source = @"pub class Test {
    pub fn main() {
        let x = 5;
        Print(x);
    }
}";
            var compiler = new Ryn.Compiler.Compiler();
            var writer = new StringWriter();
            Console.SetOut(writer);

            compiler.CompileAndRun(source);

            Assert.Contains("5", writer.ToString());
        }
    }
}
