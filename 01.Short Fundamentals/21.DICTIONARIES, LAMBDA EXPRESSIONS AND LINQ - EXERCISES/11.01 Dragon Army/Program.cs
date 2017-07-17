using System;
using System.Collections.Generic;
using System.Linq;

static class DragonArmy
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Dictionary<string, SortedDictionary<string, List<decimal>>> dragons = new Dictionary<string, SortedDictionary<string, List<decimal>>>();

        for (int i = 0; i < number; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string dragonType = input[0];
            string dragonName = input[1];
            decimal damage = GetDamageValue(input);
            decimal health = GetHealthValue(input);
            decimal armor = GetArmorValue(input);

            List<decimal> dragonStats = new List<decimal>();
            dragonStats.Add(damage);
            dragonStats.Add(health);
            dragonStats.Add(armor);

            if (!dragons.ContainsKey(dragonType))
            {
                dragons.Add(dragonType, new SortedDictionary<string, List<decimal>>());

            }
            if (!dragons[dragonType].ContainsKey(dragonName))
            {
                dragons[dragonType].Add(dragonName, new List<decimal>());
            }

            dragons[dragonType][dragonName] = dragonStats;
        }

        foreach (var key in dragons)
        {
            string type = key.Key;
            var nameOfDragons = key.Value;
            decimal averageDamage = nameOfDragons.Values.Average(v => v[0]);
            decimal averageHealth = nameOfDragons.Values.Average(v => v[1]);
            decimal averageArmor = nameOfDragons.Values.Average(v => v[2]);

            Console.WriteLine($"{type}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

            foreach (var item in nameOfDragons)
            {
                string name = item.Key;
                var stats = item.Value;
                Console.WriteLine($"-{name} -> damage: {stats[0]}, health: {stats[1]}, armor: {stats[2]}");
            }
        }
    }

    public static decimal GetArmorValue(string[] input)
    {
        decimal armor;
        if (input[4].Equals("null"))
        {
            armor = 10;
        }
        else
        {
            armor = decimal.Parse(input[4]);
        }

        return armor;
    }

    public static decimal GetHealthValue(string[] input)
    {
        decimal health;
        if (input[3].Equals("null"))
        {
            health = 250;
        }
        else
        {
            health = decimal.Parse(input[3]);
        }

        return health;
    }

    public static decimal GetDamageValue(string[] input)
    {
        decimal damage;
        if (input[2].Equals("null"))
        {
            damage = 45;
        }
        else
        {
            damage = decimal.Parse(input[2]);
        }

        return damage;
    }
}