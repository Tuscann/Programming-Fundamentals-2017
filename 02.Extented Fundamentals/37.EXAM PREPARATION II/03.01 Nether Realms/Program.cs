using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class NetherRealms
{
    public static void Main()
    {
        List<string> input = Console.ReadLine().Split(',').Select(i => i.Trim()).ToList();
        Regex lettersRegex = new Regex(@"[^0-9+\-*\/\.]");
        var demons = new SortedDictionary<string, List<double>>();
        FillDemonsNames(demons, input);
        
        foreach (KeyValuePair<string, List<double>> demon in demons)
        {
            double healthSum = 0.0;
            MatchCollection letterMatches = lettersRegex.Matches(demon.Key);
            foreach (Match match in letterMatches)
            {
                char[] matchChar = match.Value.ToCharArray();
                healthSum += matchChar[0];
            }
            demons[demon.Key].Add(healthSum);
        }
        /* get demons damage */
        Regex numbersRegex = new Regex(@"([-+]?[0-9]*\.[0-9]+|[0-9]+)|([-+]?[0-9]+)");
        Regex operandsRegex = new Regex(@"[\/*]");
        foreach (KeyValuePair<string, List<double>> demon in demons)
        {
            double damageSum = 0.0;
            MatchCollection numbersMatches = numbersRegex.Matches(demon.Key);
            foreach (Match match in numbersMatches)
            {
                double num;
                string number = match.Value;
                if (double.TryParse(number, out num))
                {
                    damageSum += num;
                }
            }
            MatchCollection operandsMatches = operandsRegex.Matches(demon.Key);
            foreach (Match match in operandsMatches)
            {
                string operand = match.Value;
                if (operand == "*")
                {
                    damageSum *= 2;
                }
                else if (operand == "/")
                {
                    damageSum /= 2;
                }
            }
            demons[demon.Key].Add(damageSum);
        }
        
        foreach (KeyValuePair<string, List<double>> demon in demons)
        {
            Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
        }
    }

    private static void FillDemonsNames(SortedDictionary<string, List<double>> demons, List<string> input)
    {
        foreach (string demon in input)
        {
            demons[demon] = new List<double>();
        }
    }
}
