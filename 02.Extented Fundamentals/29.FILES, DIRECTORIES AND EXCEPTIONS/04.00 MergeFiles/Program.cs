using System;
using System.Linq;
using System.IO;

public class Program
{
    public static void Main()
    {
        string[] fileOne = File.ReadAllLines("Input1.txt");
        string[] fileTwo = File.ReadAllLines("Input2.txt");

        string[] mergedLists = fileOne
            .Concat(fileTwo)
            .OrderBy(x => x)
            .ToArray();

        File.AppendAllText("MergeFiles.txt",
            string.Join(Environment.NewLine, mergedLists));
    }
}