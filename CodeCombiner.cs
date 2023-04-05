using System.Text;

public class CodeCombiner
{
    public static void CombineCodeFiles(string sourcePath, string outputFile, string fileExt)
    {
        StringBuilder combinedCode = new StringBuilder();
        string searchPattern = "*." + (string.IsNullOrEmpty(fileExt) ? "cs" : fileExt);
        string[] files = Directory.GetFiles(sourcePath, searchPattern, SearchOption.AllDirectories);

        foreach (string file in files)
        {
            string content = File.ReadAllText(file);
            combinedCode.AppendLine("// File: " + file);
            combinedCode.AppendLine(content);
            combinedCode.AppendLine();
        }

        File.WriteAllText(outputFile, combinedCode.ToString());
    }
}
