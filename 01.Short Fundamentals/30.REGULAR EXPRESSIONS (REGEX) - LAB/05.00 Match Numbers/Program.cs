using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
        
        string input = Console.ReadLine();
        MatchCollection datesMatches = Regex.Matches(input, pattern);

        foreach (Match date in datesMatches)
        {
            Console.Write(date + " ");
        }
    }
}