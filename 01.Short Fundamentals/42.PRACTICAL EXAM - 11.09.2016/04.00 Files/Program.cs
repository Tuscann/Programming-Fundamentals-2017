using System;
using System.Collections.Generic;
using System.Linq;
public class TestMain
{
    public static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, List<string>> rootByFileNames = new Dictionary<string, List<string>>();
        Dictionary<string, long> fileBySize = new Dictionary<string, long>();

        for (int i = 0; i < n; i++)
        {
            string inputLine = Console.ReadLine();

            string[] fileArgs = inputLine.Split('\\');
            string rootName = fileArgs[0];

            string[] fileInfo = fileArgs[fileArgs.Length - 1].Split(';');

            string fileNameAndExtension = fileInfo[0];
            long fileSize = long.Parse(fileInfo[1]);

            if (!rootByFileNames.ContainsKey(rootName))
            {
                rootByFileNames.Add(rootName, new List<string>());
            }

            rootByFileNames[rootName].Add(fileNameAndExtension);
            fileBySize[fileNameAndExtension] = fileSize;
        }

        string[] searchedFileArgs = Console.ReadLine().Split(' ');
        string extension = searchedFileArgs[0].Trim();
        string searchedRootName = searchedFileArgs[2].Trim();

        fileBySize = fileBySize.OrderByDescending(f => f.Value).ToDictionary(p => p.Key, p => p.Value);
        if (rootByFileNames.ContainsKey(searchedRootName))
        {
            List<string> allfiles = rootByFileNames[searchedRootName].Where(f => f.EndsWith(extension)).ToList();
            if (allfiles.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in fileBySize.Where(f => allfiles.Contains(f.Key)).OrderByDescending(f => f.Value).ThenBy(f => f.Key))
                {
                    Console.WriteLine($"{item.Key} - {item.Value} KB");
                }
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}