using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Program
{
    static void Main()  // 20/100
    {
        while (true)
        {
            var current = Console.ReadLine();

            if (current == "end")
            {
                break;
            }
            var pattern = @"([A-z\’]{1,})[.|!| ]?";
            var matches = Regex.Matches(current, pattern);

            var list = new List<string>();

            foreach (Match match in matches)
            {
                list.Add(match.ToString().ToLower());
            }

            int counter = 0;
            foreach (var word in list)
            {
                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(word[i].ToString().ToUpper());
                    }
                    else
                    {
                        Console.Write(word[i].ToString());
                    }
                }
                counter++;
                if (list.Count == counter)
                {
                    break;
                }
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}