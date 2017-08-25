using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int stopper = int.Parse(Console.ReadLine());
        SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> answer = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
        for (int cycle = 0; cycle < stopper; cycle++)
        {
            string[] input = Console.ReadLine().Split();

            string continent = input[0];
            string country = input[1];
            string city = input[2];

            if (!answer.Keys.Contains(continent))
            {
                answer.Add(continent, new SortedDictionary<string, SortedSet<string>>());
            }
            if (!answer[continent].ContainsKey(country))
            {
                answer[continent].Add(country, new SortedSet<string>());
            }
            answer[continent][country].Add(city);
        }

        foreach (KeyValuePair<string, SortedDictionary<string, SortedSet<string>>> continent in answer)
        {
            Console.WriteLine($"{continent.Key}:");
            foreach (KeyValuePair<string, SortedSet<string>> country in continent.Value)
            {
                Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
            }
        }
    }
}