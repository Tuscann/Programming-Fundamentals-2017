using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main() // 100/100
    {
        List<string> output = new List<string>();
        List<string> inputLine = new List<string>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            inputLine.Add(Console.ReadLine());
        }

        for (int i = 0; i < inputLine.Count; i++)
        {
            string currentLine = inputLine[i];

            for (int j = 0; j < currentLine.Length; j++)
            {
                char currentChar = currentLine[j];
                int layer = 1;
                string currentPyramid = string.Empty;

                for (int k = i; k < inputLine.Count; k++)
                {
                    string currentLayer = new string(currentChar, layer);

                    if (inputLine[k].Contains(currentLayer))
                    {
                        currentPyramid += currentLayer + Environment.NewLine;
                    }
                    else
                    {
                        break;
                    }

                    layer += 2;
                }

                output.Add(currentPyramid.Trim());
            }
        }
        Console.WriteLine(output.OrderByDescending(x => x.Length).First());
    }
}