using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var dic = new Dictionary<string, SortedDictionary<string, List<double>>>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var currentRow = Console.ReadLine().Split().ToList();

            string type = currentRow[0];
            string name = currentRow[1];

            if (currentRow[2] == "null")
            {
                currentRow[2] = "45";
            }
            if (currentRow[3] == "null")
            {
                currentRow[3] = "250";
            }
            if (currentRow[4] == "null")
            {
                currentRow[4] = "10";
            }
            int damage = int.Parse(currentRow[2]);
            int health = int.Parse(currentRow[3]);
            int armor = int.Parse(currentRow[4]);

            if (!dic.ContainsKey(type))
            {
                dic[type] = new SortedDictionary<string, List<double>>();
            }
            if (!dic[type].ContainsKey(name))
            {
                dic[type][name] = new List<double>();
                dic[type][name].Add(0);
                dic[type][name].Add(0);
                dic[type][name].Add(0);
            }
            dic[type][name][0] = damage;
            dic[type][name][1] = health;
            dic[type][name][2] = armor;
        }

        foreach (var dragonData in dic)
        {
            double averageDamage = dragonData.Value.Select(x => x.Value[0]).Average();
            double averageHealths = dragonData.Value.Select(x => x.Value[1]).Average();
            double averageArmor = dragonData.Value.Select(x => x.Value[2]).Average();

            Console.WriteLine($"{dragonData.Key}::({averageDamage:f2}/{averageHealths:f2}/{averageArmor:f2})");
            foreach (var currentDragon in dragonData.Value)
            {
                Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}",
                    currentDragon.Key,
                    currentDragon.Value[0],
                    currentDragon.Value[1],
                    currentDragon.Value[2]
                );
            }
        }
    }
}