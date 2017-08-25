using System;
using System.Collections.Generic;
using System.Linq;
class Wardrobe_2
{
    static void Main() // 100/100
    {
        Dictionary<string, Dictionary<string, int>> clothesData = new Dictionary<string, Dictionary<string, int>>();
        int n = int.Parse(Console.ReadLine());

        for (int cnt = 0; cnt < n; cnt++)
        {
            string[] input = Console.ReadLine().Split(new string[] { " -> " },
            StringSplitOptions.None).ToArray();
            string color = input[0];
            string[] clothesToAdd = input[1].Split(',').ToArray();

            for (int i = 0; i < clothesToAdd.Length; i++)
            {
                string clothesType = clothesToAdd[i];

                if (!clothesData.ContainsKey(color))
                {
                    clothesData.Add(color, new Dictionary<string, int>());
                    clothesData[color].Add(clothesType, 1);
                }
                else
                {
                    if (!clothesData[color].ContainsKey(clothesType))
                    {
                        clothesData[color].Add(clothesType, 1);
                    }
                    else
                    {
                        clothesData[color][clothesType] += 1;
                    }
                }
            }
        }

        string[] itemToFind = Console.ReadLine().Split(' ').ToArray();
        string itemToFindColor = itemToFind[0];
        string itemToFindType = itemToFind[1];

        foreach (var color in clothesData)
        {
            string clothesColor = color.Key;
            Dictionary<string, int> clothesType = color.Value;
            Console.WriteLine("{0} clothes:", clothesColor);

            foreach (var clothes in clothesType)
            {
                string clothingItem = clothes.Key;
                int clothingCount = clothes.Value;

                if (clothesColor == itemToFindColor && clothingItem.CompareTo(itemToFindType) == 0)
                {
                    Console.WriteLine("* {0} - {1} (found!)", clothingItem, clothingCount);
                }
                else
                {
                    Console.WriteLine("* {0} - {1}", clothingItem, clothingCount);
                }
            }
        }
    }
}