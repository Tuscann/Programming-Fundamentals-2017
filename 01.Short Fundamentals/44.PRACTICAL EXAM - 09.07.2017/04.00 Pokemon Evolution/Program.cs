using System;
using System.Collections.Generic;
using System.Linq;
class PokemonEvolution
{
    static void Main() //  100/100
    {
        Dictionary<string, List<Evolution>> data = new Dictionary<string, List<Evolution>>();

        string input = Console.ReadLine();

        while (input != "wubbalubbadubdub")
        {
            string[] tokens = input.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string pokemonName = tokens[0];

            if (tokens.Length == 1 && data.ContainsKey(pokemonName))
            {
                PrintPokemons(pokemonName, data);
            }
            else
            {
                try
                {
                    string evolutionType = tokens[1];
                    long evolutionIndex = long.Parse(tokens[2]);

                    Evolution evolution = new Evolution(evolutionType, evolutionIndex);

                    if (!data.ContainsKey(pokemonName))
                    {
                        data.Add(pokemonName, new List<Evolution>());
                    }
                    data[pokemonName].Add(evolution);
                }
                catch
                {

                }

            }
            input = Console.ReadLine();
        }

        foreach (var pokemonData in data)
        {
            string pokemonName = pokemonData.Key;
            List<Evolution> evolutions = pokemonData.Value;

            Console.WriteLine($"# {pokemonName}");

            foreach (Evolution evolutionData in evolutions.OrderByDescending(e => e.EvolutionIndex))
            {
                string evolutionType = evolutionData.EvolutionType;
                long evolutionIndex = evolutionData.EvolutionIndex;

                Console.WriteLine($"{evolutionType} <-> {evolutionIndex}");
            }
        }

    }

    private static void PrintPokemons(string pokemonName, Dictionary<string, List<Evolution>> data)
    {
        foreach (var item in data.Where(k => k.Key == pokemonName))
        {
            Console.WriteLine($"# {pokemonName}");

            List<Evolution> evolutionData = item.Value;

            foreach (var evolution in evolutionData)
            {
                string evolutionType = evolution.EvolutionType;
                long evolutionIndex = evolution.EvolutionIndex;

                Console.WriteLine($"{evolutionType} <-> {evolutionIndex}");
            }
        }
    }
    class Evolution
    {
        public string EvolutionType { get; set; }
        public long EvolutionIndex { get; set; }

        public Evolution(string evolutionType, long evolutionIndex)
        {
            this.EvolutionType = evolutionType;
            this.EvolutionIndex = evolutionIndex;
        }
    }
}