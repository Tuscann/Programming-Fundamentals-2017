using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Program
{
    static void Main()   // 100/100
    {
        string pattern = @"(?<power>\d+|[JQKA]+)(?<suit>[SHDC])";
        MatchCollection matches = Regex.Matches(Console.ReadLine(), pattern);
        List<string> result = new List<string>();
        foreach (Match match in matches)
        {
            string power = match.Groups["power"].Value;
            
            int number;
            bool parst = int.TryParse(power, out number);
            if (parst && number >= 2 && number <= 10)
            {
                result.Add(match.Groups[0].Value);
            }
            else if (power == "J" || power == "Q" || power == "K" || power == "A") result.Add(match.Groups[0].Value);
        }
        Console.WriteLine(string.Join(", ", result));
    }
}
