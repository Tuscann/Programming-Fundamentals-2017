using System;
using System.Collections.Generic;
using System.Linq;
public class PopulationCounter
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, Dictionary<string, long>> countriesAndCities = new Dictionary<string, Dictionary<string, long>>();
        Dictionary<string, long> countriesAndPopulation = new Dictionary<string, long>();

        while (!input.Equals("report"))
        {
            string[] inputData = input.Split('|');
            string city = inputData[0];
            string country = inputData[1];
            long population = long.Parse(inputData[2]);

            if (!countriesAndCities.ContainsKey(country) && !countriesAndPopulation.ContainsKey(country))
            {
                countriesAndCities.Add(country, new Dictionary<string, long>());
                countriesAndPopulation.Add(country, 0);
            }
            if (!countriesAndCities[country].ContainsKey(city))
            {
                countriesAndCities[country].Add(city, 0);
            }

            countriesAndCities[country][city] += population;
            countriesAndPopulation[country] += population;

            input = Console.ReadLine();
        }

        foreach (KeyValuePair<string, long> country in countriesAndPopulation.OrderByDescending(p => p.Value))
        {
            Console.WriteLine($"{country.Key} (total population: {country.Value})");

            Dictionary<string, long> cities = countriesAndCities[country.Key];

            foreach (KeyValuePair<string, long> city in cities.OrderByDescending(p => p.Value))
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }
    }
}