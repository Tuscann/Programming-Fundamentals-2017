using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main()  // 100/100
    {
        Dictionary<string, List<string>> solution = new Dictionary<string, List<string>>();
        Regex toRegex = new Regex(@"^([A-Za-z]{5,})@([a-z]{3,}(\.com|\.bg|\.org){1})$");

        int rotation = int.Parse(Console.ReadLine());

        for (int cycle = 0; cycle < rotation; cycle++)
        {
            string mail = Console.ReadLine();

            MatchCollection groupByMail = toRegex.Matches(mail);

            foreach (Match domain in groupByMail)
            {
                string afterAlpha = domain.Groups[2].Value.ToString();
                string name = domain.Groups[1].Value.ToString();

                if (!solution.ContainsKey(afterAlpha))
                {
                    solution[afterAlpha] = new List<string>();
                }

                if (!solution[afterAlpha].Contains(name))
                {
                    solution[afterAlpha].Add(name);
                }
            }
        }
        foreach (var domainAndName in solution.OrderByDescending(x => x.Value.Count))
        {
            Console.WriteLine($"{domainAndName.Key}:");
            foreach (var people in domainAndName.Value)
            {
                Console.WriteLine("### {0}", people);
            }
        }
    }
}