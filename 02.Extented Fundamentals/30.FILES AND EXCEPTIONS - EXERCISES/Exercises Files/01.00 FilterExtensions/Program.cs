using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Program
{
    public static void Main()
    {
        string givenExt = Console.ReadLine();

        string[] inputFileNames = Directory.GetFiles("input");
        List<string> filesWithGivenExtention = new List<string>();

        foreach (var item in inputFileNames)
        {
            string[] currentFileName = item
                .Split(new[] { '.' },
                    StringSplitOptions.RemoveEmptyEntries);

            var reversedFileName = currentFileName.Reverse().ToArray();
            if (reversedFileName[0] == givenExt)
            {
                filesWithGivenExtention.Add(item);
            }
        }

        Console.WriteLine(string.Join(Environment.NewLine, filesWithGivenExtention));
    }
}