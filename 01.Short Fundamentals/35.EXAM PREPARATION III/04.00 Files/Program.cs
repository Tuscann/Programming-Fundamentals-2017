using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class File
{
    public string Root { get; set; }
    public string FileName { get; set; }
    public string Extension { get; set; }
    public long Size { get; set; }
}

class Files
{
    static void Main() // 100/100
    {

        int n = int.Parse(Console.ReadLine());
        List<File> allFiles = new List<File>();
        for (int i = 0; i < n; i++)
        {
            string inputLine = Console.ReadLine();
            string root = ExtractRoot(inputLine);

            int mostRightSemicolonIndex = inputLine.LastIndexOf(";");
            long size = 0;
            if (mostRightSemicolonIndex >= 0)
            {
                size = long.Parse(inputLine.Substring(mostRightSemicolonIndex + 1));
                string pathPlusName = inputLine.Substring(0, mostRightSemicolonIndex);

                string ext = ExtractExtension(pathPlusName);
                string fileName = ExtractFileName(pathPlusName);

                File match = allFiles.FirstOrDefault(
                    f => f.FileName == fileName &&
                         f.Root == root);
                if (match != null)
                {
                    match.Size = size;
                }
                else
                {
                    File file = new File()
                    {
                        Root = root,
                        FileName = fileName,
                        Extension = ext,
                        Size = size
                    };
                    allFiles.Add(file);
                }
            }
        }

        string[] query = Regex.Split(Console.ReadLine(), @"\s+in\s+");
        string extQuery = query[0];
        string rootQuery = query[1];

        IOrderedEnumerable<File> resultFiles = allFiles
            .Where(f => f.Root == rootQuery)
            .Where(f => f.Extension == extQuery)
            .OrderByDescending(f => f.Size)
            .ThenBy(f => f.FileName);

        if (resultFiles.Any())
        {
            foreach (File f in resultFiles)
            {
                Console.WriteLine($"{f.FileName} - {f.Size} KB ");
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    static string ExtractExtension(string pathPlusName)
    {
        int mostRightDotIndex = pathPlusName.LastIndexOf(@".");
        string ext = "";
        if (mostRightDotIndex >= 0)
        {
            ext = pathPlusName.Substring(mostRightDotIndex + 1);
        }
        return ext;
    }

    static string ExtractRoot(string inputLine)
    {
        int mostLeftSlashIndex = inputLine.IndexOf(@"\");
        string root = "";
        if (mostLeftSlashIndex >= 0)
        {
            root = inputLine.Substring(0, mostLeftSlashIndex);
        }
        return root;
    }

    static string ExtractFileName(string pathPlusName)
    {
        int mostRightSlashIndex = pathPlusName.LastIndexOf(@"\");
        string fileName = "";
        if (mostRightSlashIndex >= 0)
        {
            fileName = pathPlusName.Substring(mostRightSlashIndex + 1);
        }
        return fileName;
    }
}