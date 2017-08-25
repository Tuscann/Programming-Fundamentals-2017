using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        int stopper = int.Parse(Console.ReadLine());

        var continentCountryCity = new Dictionary<string, Dictionary<string, List<string>>>();

        for (int cycle = 0; cycle < stopper; cycle++)
        {
            string[] input = Console.ReadLine().Split();

            if (!continentCountryCity.ContainsKey(input[0]))
            {
                continentCountryCity[input[0]] = new Dictionary<string, List<string>>();
                continentCountryCity[input[0]][input[1]] = new List<string>();
            }
            else if (!continentCountryCity[input[0]].ContainsKey(input[1]))
            {
                continentCountryCity[input[0]][input[1]] = new List<string>();
            }
            continentCountryCity[input[0]][input[1]].Add(input[2]);
        }
        foreach (var kvp in continentCountryCity)
        {
            Console.WriteLine($"{kvp.Key}:");
            foreach (var countryAndCity in kvp.Value)
            {
                Console.WriteLine($"  {countryAndCity.Key} -> {string.Join(", ", countryAndCity.Value)}");
            }
        }
    }
}