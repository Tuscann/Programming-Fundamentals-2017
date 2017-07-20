using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int stopper = int.Parse(Console.ReadLine());
        var answer = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
        for (int cycle = 0; cycle < stopper; cycle++)
        {
            string[] input = Console.ReadLine().Split();

            var continent = input[0];
            var country = input[1];
            var city = input[2];

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

        foreach (var continent in answer)
        {
            Console.WriteLine($"{continent.Key}:");
            foreach (var country in continent.Value)
            {
                Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
            }
        }
    }
}