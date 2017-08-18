using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()   // 90/100
    {
        string[] names = Console.ReadLine().Split(new string[] { ",", " ","\t" }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        names = CheckNames(names);
        var fighters = new Dictionary<string, Dictionary<double, double>>();
        string numberPatter = @"([-+ ]?[\d]+[\.]?[\d]+)|\d";

        foreach (string name in names)
        {
            Match currNameMAtch = Regex.Match(name, @"[^\+\-\*\/0-9\.\s\,]");
            if (currNameMAtch.Success)
            {
                if (!fighters.ContainsKey(name))
                {
                    fighters.Add(name, new Dictionary<double, double>());
                }

                double health = FighterHealth(name);
                double power = FighterPower(name, numberPatter);

                fighters[name][health] = power;
            }

        }
        IOrderedEnumerable<KeyValuePair<string, Dictionary<double, double>>> orderedFighters = fighters.OrderBy(f => f.Key);
        foreach (KeyValuePair<string, Dictionary<double, double>> fighter in orderedFighters)
        {
            Console.Write("{0} - ", fighter.Key);

            Dictionary<double, double> stats = fighter.Value;
            foreach (KeyValuePair<double, double> stat in stats)
            {
                Console.WriteLine($"{stat.Key} health, {stat.Value:F2} damage");
            }
        }
    }

    private static string[] CheckNames(string[] names)
    {
        List<string> newArray = new List<string>();
        foreach (string name in names)
        {
            if (!name.Contains(" "))
            {
                if (!name.Contains(","))
                {
                    newArray.Add(name);
                }
            }
        }

        return newArray.ToArray();
    }

    private static double FighterPower(string name, string numberPatter)
    {
        double power = Regex.Matches(name, numberPatter)
            .Cast<Match>().Select(n => n.Value).Select(double.Parse).ToArray()
            .Sum();
        
        string pattern = @"[*\/]?";
        string[] maths = Regex.Matches(name, pattern).Cast<Match>().Select(m => m.Value).ToArray();

        foreach (string math in maths)
        {
            if (math == "*")
            {
                power *= 2;
            }
            else if (math == "/")
            {
                power /= 2;
            }
        }

        return power;
    }

    private static double FighterHealth(string name)
    {
        string[] currMatch = Regex.Matches(name, @"[^\+\-\*\/0-9\.\s\,]")
            .Cast<Match>().Select(m => m.Value).ToArray();

        double health = 0;

        for (int i = 0; i < currMatch.Length; i++)
        {
            health += char.Parse(currMatch[i]);
        }

        return health;
    }
}
