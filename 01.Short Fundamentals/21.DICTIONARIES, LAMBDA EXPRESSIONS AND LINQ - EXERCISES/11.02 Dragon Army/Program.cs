using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class DragonArmy
{
    public static void Main()
    {
        Dictionary<string, SortedDictionary<string, int[]>> data = new Dictionary<string, SortedDictionary<string, int[]>>();
        Regex regex = new Regex(@"([a-zA-Z]*)\s*([a-zA-Z]*)\s*(null|\d+)\s*(null|\d+)\s*(null|\d+)");

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            Match match = regex.Match(input);

            if (match.Success)
            {
                string type = match.Groups[1].Value;
                string name = match.Groups[2].Value;

                int damage = match.Groups[3].Value == "null" ? 45 : int.Parse(match.Groups[3].Value);
                int health = match.Groups[4].Value == "null" ? 250 : int.Parse(match.Groups[4].Value);
                int armor = match.Groups[5].Value == "null" ? 10 : int.Parse(match.Groups[5].Value);

                if (!data.ContainsKey(type))
                {
                    data.Add(type, new SortedDictionary<string, int[]>());
                }
                if (!data[type].ContainsKey(name))
                {
                    data[type][name] = new int[3];
                }
                data[type][name][0] = damage;
                data[type][name][1] = health;
                data[type][name][2] = armor;
            }
        }
        foreach (KeyValuePair<string, SortedDictionary<string, int[]>> outerPair in data)
        {
            Console.WriteLine("{0}::({1:F}/{2:f}/{3:f})",
                outerPair.Key, outerPair.Value.Select(x => x.Value[0]).Average(),
                outerPair.Value.Select(x => x.Value[1]).Average(),
                outerPair.Value.Select(x => x.Value[2]).Average());

            foreach (KeyValuePair<string, int[]> inner in outerPair.Value)
            {
                Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", inner.Key, inner.Value[0],
                    inner.Value[1], inner.Value[2]);
            }
        }
    }
}