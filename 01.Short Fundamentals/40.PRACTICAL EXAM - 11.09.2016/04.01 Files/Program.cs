using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Files
{
    public static void Main() // 100/100
    {
        int fileCount = int.Parse(Console.ReadLine());

        List<string> files = ReadFiles(fileCount);

        string[] queryParams = Console.ReadLine().Split();

        PrintResult(ExecuteQuery(files, queryParams[0], queryParams[2]));
    }

    private static void PrintResult(Dictionary<string, int> filteredFiles)
    {
        if (filteredFiles.Count == 0)
        {
            Console.WriteLine("No");
            return;
        }

        foreach (KeyValuePair<string, int> file in filteredFiles)
        {
            Console.WriteLine($"{file.Key} - {file.Value} KB");
        }
    }

    private static Dictionary<string, int> ExecuteQuery(List<string> files, string extension, string rootFolder)
    {
        Dictionary<string, int> filteredFiles = files
            .Where(file => file.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries)[0] == rootFolder)
            .Where(file =>
            {
                string ext = Path.GetExtension(file
                    .Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries)
                    .Last()
                    .Split(';')[0]);

                return !string.IsNullOrEmpty(ext) && ext.Substring(1) == extension;
            })
            .ToLookup(file => file
                    .Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries)
                    .Last()
                    .Split(';')[0],
                file => int.Parse(file
                    .Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries)
                    .Last()
                    .Split(';')[1]))
            .ToDictionary(pair => pair.Key, pair => pair.Last())
            .OrderByDescending(file => file.Value)
            .ThenBy(file => file.Key)
            .ToDictionary(pair => pair.Key, pair => pair.Value);

        return filteredFiles;
    }

    private static List<string> ReadFiles(int fileCount)
    {
        List<string> files = new List<string>();

        for (int i = 0; i < fileCount; i++)
        {
            files.Add(Console.ReadLine());
        }

        return files;
    }
}