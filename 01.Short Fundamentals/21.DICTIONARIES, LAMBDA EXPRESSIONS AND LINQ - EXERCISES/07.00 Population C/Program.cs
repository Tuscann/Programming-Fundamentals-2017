using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split('|').ToList();
        var dict = new Dictionary<string, Dictionary<string, long>>();

        while (true)
        {
            if (input[0] == "report") { break; }

            string city = input[0];
            string country = input[1];
            int population = int.Parse(input[2]);

            if (!dict.ContainsKey(country))
            {
                dict.Add(country, new Dictionary<string, long>());
                dict[country].Add(city, population);
            }
            if (!dict[country].ContainsKey(city))
            {
                dict[country].Add(city, population);
            }
            input = Console.ReadLine().Split('|').ToList();
        }
        
        foreach (var countryy in dict.OrderByDescending(x => x.Value.Sum(y => y.Value)))
        {
            List<long> sumOfTowns = countryy.Value.Select(x => x.Value).ToList();

            Console.WriteLine("{0} (total population: {1})", countryy.Key, sumOfTowns.Sum());

            foreach (var cityy in countryy.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("=>{0}: {1}", cityy.Key, cityy.Value);
            }
        }
    }
}