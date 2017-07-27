using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class Query_Mess
{
    public static void Main()
    {
        var firstPattern = @"([^&?]+)=([^&?]+)";
        var secondPatter = @"(%20|\+)+";

        var line = Console.ReadLine();

        while (!line.Equals("END"))
        {
            var matches = Regex.Matches(line, firstPattern);

            var dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < matches.Count; i++)
            {
                var field = matches[i].Groups[1].Value;
                field = Regex.Replace(field, secondPatter, word => " ").Trim();

                var value = matches[i].Groups[2].Value;
                value = Regex.Replace(value, secondPatter, word => " ").Trim();

                if (!dictionary.ContainsKey(field))
                {
                    dictionary[field] = new List<string>();
                }

                dictionary[field].Add(value);
            }

            foreach (var kvpResult in dictionary)
            {
                Console.Write($"{kvpResult.Key}=[{string.Join(", ", kvpResult.Value)}]");
            }

            Console.WriteLine();

            line = Console.ReadLine();
        }
    }
}