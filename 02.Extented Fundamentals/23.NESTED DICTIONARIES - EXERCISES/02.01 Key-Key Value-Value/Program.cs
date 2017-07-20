using System;
using System.Collections.Generic;
using System.Linq;
class KeyKeyValueValue
{
    static void Main()   //    100/100
    {
        var pairs = new Dictionary<string, List<string>>();
        string key = Console.ReadLine();
        string value = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new string[] { " => " },
                StringSplitOptions.None).ToArray();
            string searchKey = input[0];
            string[] valuesArray = input[1].Split(';').ToArray();

            if (searchKey.Contains(key))
            {
                if (!pairs.ContainsKey(searchKey))
                {
                    pairs.Add(searchKey, new List<string>());
                }
                foreach (string searchValue in valuesArray)
                {
                    if (searchValue.Contains(value))
                    {
                        pairs[searchKey].Add(searchValue);
                    }
                }
            }
        }
        foreach (var pair in pairs)
        {
            string currentKey = pair.Key;
            Console.WriteLine($"{currentKey}:");

            List<string> list = pair.Value;
            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine($"-{list[index]}");
            }
        }
    }
}
