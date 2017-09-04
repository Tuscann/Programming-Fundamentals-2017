using System;
using System.Collections.Generic;
using System.Linq;
public class PokemonEvolution
{
    public static void Main() // 100/100
    {
        string input = Console.ReadLine();
        Dictionary<string, List<string>> pokemons = new Dictionary<string, List<string>>();

        while (!input.Equals("wubbalubbadubdub"))
        {
            string[] pokemonInfo = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            if (pokemonInfo.Length == 1)
            {
                string key = pokemonInfo[0];
                if (pokemons.ContainsKey(key))
                {
                    Console.WriteLine($"# {key}");

                    foreach (var item in pokemons[key])
                    {
                        string[] currentPair = item.Split();
                        string type = currentPair[0];
                        long currentIndex = long.Parse(currentPair[1]);
                        Console.WriteLine($"{type} <-> {currentIndex}");
                    }
                }
            }
            else
            {
                string pokemonName = pokemonInfo[0];
                string evolutionType = pokemonInfo[1];
                long evolotionIndex = long.Parse(pokemonInfo[2]);

                if (!pokemons.ContainsKey(pokemonName))
                {
                    pokemons.Add(pokemonName, new List<string>());
                }

                pokemons[pokemonName].Add(evolutionType + " " + evolotionIndex);
            }

            input = Console.ReadLine();
        }

        foreach (var pokemon in pokemons)
        {
            Console.WriteLine($"# {pokemon.Key}");
            foreach (var elem in pokemon.Value.OrderByDescending(x => int.Parse(x.Split()[1])))
            {
                string[] result = elem.Split();
                Console.WriteLine($"{result[0]} <-> {result[1]}");
            }

        }
    }
}