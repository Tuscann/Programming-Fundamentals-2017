using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        List<int> inputs = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<string> output = new List<string>();
        
        int distance = inputs[0];
        int countOfElements = inputs[1];

        string pattern = "\\<<<(.){" + distance + "}(?<name>.){" + countOfElements + "}";
        string input = Console.ReadLine();

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match key in matches)
        {
            output.Add(key.ToString().Remove(0, distance + 3));
        }
        Console.WriteLine("{0}", string.Join("/\\", output));
    }
}