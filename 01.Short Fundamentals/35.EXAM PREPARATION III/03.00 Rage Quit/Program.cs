using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
class E03_RageQuit
{
    static void Main() // 100/100
    {
        string inputString = Console.ReadLine().ToUpper();
        MatchCollection matches = Regex.Matches(inputString, @"(?<str>\D+)(?<count>\d+)");
        StringBuilder sb = new StringBuilder();
        foreach (Match match in matches)
        {
            if (match.Success)
            {
                string message = match.Groups["str"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                for (int i = 0; i < count; i++)
                {
                    sb.Append(message);
                }
            }
        }
        string result = sb.ToString();
        int uniqueSymbolsCount = result.Distinct().Count();

        Console.WriteLine($"Unique symbols used: {uniqueSymbolsCount}");
        Console.WriteLine(result);
    }
}