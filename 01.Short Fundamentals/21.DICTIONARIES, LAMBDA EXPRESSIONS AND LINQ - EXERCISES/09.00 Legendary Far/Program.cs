using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
        Dictionary<string, int> possibelItems = new Dictionary<string, int>();
        possibelItems.Add("shards", 0);
        possibelItems.Add("fragments", 0);
        possibelItems.Add("motes", 0);

        string legendaryMaterial = string.Empty;
        bool isOK = true;

        while (isOK)
        {
            List<string> curentRow = Console.ReadLine().ToLower().Split().ToList();

            for (int i = 0; i < curentRow.Count; i += 2)
            {
                int quantity = int.Parse(curentRow[i]);
                string material = curentRow[i + 1];

                if (material == "shards" || material == "fragments" || material == "motes")
                {
                    possibelItems[material] += quantity;
                }
                else
                {
                    if (!junk.ContainsKey(material))
                    {
                        junk[material] = quantity;
                    }
                    else
                    {
                        junk[material] += quantity;
                    }
                }
                if (possibelItems.ContainsKey(material) && possibelItems[material] >= 250)
                {
                    possibelItems[material] -= 250;
                    legendaryMaterial = material;
                    isOK = false;
                    break;
                }
            }

        }

        switch (legendaryMaterial)
        {
            case "fragments":
                Console.WriteLine("Valanyr obtained!");
                break;
            case "shards":
                Console.WriteLine("Shadowmourne obtained!");
                break;
            case "motes":
                Console.WriteLine("Dragonwrath obtained!");
                break;
        }

        foreach (KeyValuePair<string, int> item in possibelItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine("{0}: {1}", item.Key, item.Value);
        }
        foreach (KeyValuePair<string, int> mat in junk)
        {
            Console.WriteLine("{0}: {1}", mat.Key, mat.Value);
        }
    }
}