using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split('|').ToList();
        var dict = new Dictionary<string, Dictionary<string, int>>();

        while (true)
        {
            if (input[0] == "report") { break; }

            string city = input[0];
            string country = input[1];
            int population = int.Parse(input[2]);

            if (!dict.ContainsKey(country))
            {
                dict.Add(country, new Dictionary<string, int>());
                dict[country].Add(city, population);
            }
            if (!dict[country].ContainsKey(city))
            {
                dict[country].Add(city, population);
            }
            input = Console.ReadLine().Split('|').ToList();
        }
        dict.OrderByDescending(key => key.Value.Values.Sum());

        foreach (var countryy in dict)
        {
            long population = 0;
            Console.WriteLine("{0} (total population: {1})", countryy.Key, countryy.Value.Sum(d => d.Value));
            foreach (var cityy in countryy.Value)
            {
                Console.WriteLine("=>{0}: {1}", cityy.Key,cityy.Value);
            }
        }
    }
}