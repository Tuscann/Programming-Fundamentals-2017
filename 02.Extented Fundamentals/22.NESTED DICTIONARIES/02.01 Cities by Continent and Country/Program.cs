using System;
using System.Collections.Generic;
class cityByContinentAndCountry
{
    static void Main()  //   100/100
    {
        int count = int.Parse(Console.ReadLine());
        var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();

        for (int i = 0; i < count; i++)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            string continent = tokens[0];
            string country = tokens[1];
            string city = tokens[2];

            if (!continentsData.ContainsKey(continent))  // if not contains key continent add new dictionary with list inside
            {
                continentsData[continent] = new Dictionary<string, List<string>>();
            }
            if (!continentsData[continent].ContainsKey(country)) //if not contains key country add new dictionary with list inside
            {
                continentsData[continent][country] = new List<string>();
            }
            continentsData[continent][country].Add(city); //add continent-> country -> city
        }
        foreach (var continent in continentsData)
        {
            Console.WriteLine($"{continent.Key}:");
            foreach (var countryCities in continent.Value)
            {
                Console.WriteLine($"{countryCities.Key} -> {string.Join(", ", countryCities.Value)}");
            }
        }
    }
}