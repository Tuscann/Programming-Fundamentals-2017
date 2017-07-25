using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string pattern = @"\b[A-Z]{1}[a-z]{1,} [A-Z]{1}[a-z]{1,}\b";

        string input = Console.ReadLine();

        MatchCollection matchNames = Regex.Matches(input, pattern);

        foreach (var match in matchNames)
        {
            Console.Write(match + " ");
        }
        Console.WriteLine();
    }
}