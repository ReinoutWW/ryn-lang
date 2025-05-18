# Ryn

![20250201_1953_Exploring Ryn's Futuristic Design_remix_01jk1drpm6ejcbeqsbqeg37c3d](https://github.com/ReinoutWW/ryn-lang/blob/master/RYN.gif)


**Ryn** is a modern, expressive, and minimalist programming language designed to empower developers with elegant syntax and robust performance. Whether you're building scalable applications, prototyping new ideas, or exploring new paradigms, Ryn aims to make coding both enjoyable and efficient.

Why? Quoniam Possumus

## Features

- **Clean & Intuitive Syntax**: Designed to be human-readable while remaining succinct.
- **Modern Paradigms**: Supports functional, object-oriented, and concurrent programming.
- **High Performance**: Optimized runtime for fast execution.
- **Cross-Platform**: Write once, run anywhere.
- **Rich Standard Library**: A versatile set of built-in tools and utilities to kickstart your projects.

## Solution architecture
```
Ryn-lang.sln                 // The main solution file
└── src
    ├── Ryn.CLI              // Console app (the compiler "front-end" CLI)
    ├── Ryn.Lexer            // Lexical analysis library
    ├── Ryn.Parser           // Parsing library
    ├── Ryn.AST              // Abstract Syntax Tree definitions
    ├── Ryn.Semantic         // Semantic analysis/type-checking
    ├── Ryn.CodeGen          // Code generation / bytecode / IL / transpiler
    ├── Ryn.Runtime          // (Optional) Runtime support or standard library
    └── Ryn.Compiler         // High-level orchestration combining Lexer, Parser, AST, Semantic, CodeGen
└── tests
    └── Ryn.Compiler.Tests   // Unit tests and integration tests
```

## Getting Started

To compile a Ryn source file and execute the generated C# code, use the CLI:

```bash
dotnet run --project Ryn-lang/Ryn.CLI -f path/to/file.ryn
```

The example below prints a greeting:

```ryn
pub class Hello {
    pub fn greet() {
        Print("Hello from Ryn!");
    }
}
```

