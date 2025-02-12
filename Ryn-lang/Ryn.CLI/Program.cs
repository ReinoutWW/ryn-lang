namespace Ryn.CLI;


class Program
{
    public static int Main(string[] args)
    {
        // If no arguments are provided, print usage and exit.
        ValidateInput(args);

        // Parse CLI arguments.
        string? filePath = GetFilePathFromArgs(args);
        
        ValidateFilePath(filePath);

        try
        {
            string source = ReadFileContext(filePath);
            CompileAndRun(source);

            Console.WriteLine($"Ryn Compiler: Successfully compiled and executed {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ryn Compiler: Error - {ex.Message}");
            return 1;
        }

        return 0;
    }

    private static void ValidateFilePath(string? filePath)
    {
        if (filePath == null || !File.Exists(filePath))
        {
            var errorMessage = "Ryn Compiler: Invalid file specified.";
            Console.WriteLine(errorMessage);
            throw new ArgumentException(errorMessage);
        }
    }

    private static void ValidateInput(string[] args)
    {
        if (args.Length == 0)
        {
            var errorMessage = "Ryn Compiler: No file specified. Use -f <filename> to specify a file.";
            Console.WriteLine(errorMessage);
            throw new ArgumentException(errorMessage);
        }
    }

    private static string? GetFilePathFromArgs(string[] args)
    {
        string? filePath = null;
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "-f" && i + 1 < args.Length)
            {
                filePath = args[i + 1];
                break;
            }
        }

        return filePath;
    }

    private static string ReadFileContext(string? filePath)
    {
        return File.ReadAllText(filePath);
    }

    private static void CompileAndRun(string source)
    {
        var compiler = new Ryn.Compiler.Compiler();
        compiler.CompileAndRun(source);
    }
}

