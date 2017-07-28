using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        string pattern = @"(?<username>[A-Za-z]{5,})@(?<mail>[a-z]{3,})(?<domain>.com|.bg|.org)$";

        var dic = new Dictionary<string, List<string>>();

        for (int i = 0; i < n; i++)
        {
            var curentLine = Console.ReadLine();
            MatchCollection matches = Regex.Matches(curentLine, pattern);

            foreach (Match match in matches)
            {
                string username = match.Groups["username"].Value;
                string letter = match.Groups["mail"].Value;
                string domain = match.Groups["domain"].Value;

                string key = letter + domain;
                
                if (!dic.ContainsKey(key))
                {
                    dic[key] = new List<string>();

                }
                if (!dic[key].Contains(username))
                {
                    dic[key].Add(username);
                }
            }
        }
        foreach (var key in dic.OrderByDescending(x=>x.Value.Count))
        {
            Console.WriteLine("{0}:", key.Key);
            foreach (var name in key.Value)
            {
                Console.WriteLine("### {0}", name);
            }
        }
    }
}