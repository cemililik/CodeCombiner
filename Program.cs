using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string sourcePath = GetSourcePath();
        string outputFile = GetOutputFilePath();
        string fileExt = GetFileExtension();

        try
        {
            CodeCombiner.CombineCodeFiles(sourcePath, outputFile, fileExt);
        }
        catch (Exception)
        {
            Console.WriteLine("Something happened! Please check your inputs and try again!");
            return;
        }

        Console.WriteLine("Done. Please check " + outputFile);
    }

    private static string GetSourcePath()
    {
        Console.Write("Please provide Source Path (default: current directory): ");
        string sourcePath = Console.ReadLine();
        return string.IsNullOrEmpty(sourcePath) ? Directory.GetCurrentDirectory() : sourcePath;
    }

    private static string GetOutputFilePath()
    {
        Console.Write("Please provide Output path (ex: C:\\your_output_file_path\\output.txt): ");
        return Console.ReadLine();
    }

    private static string GetFileExtension()
    {
        Console.Write("Please provide file extension (ex: cs, py, go, etc.): ");
        return Console.ReadLine();
    }
}
