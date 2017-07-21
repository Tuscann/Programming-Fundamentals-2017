using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string key = Console.ReadLine();
        string input = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        var dict = new Dictionary<string, List<string>>();

        for (int i = 0; i < n; i++)
        {
            string[] inputTokens = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
            string inputKey = inputTokens[0];
            string[] inputValue = inputTokens[1].Split(';');

            if (inputKey.Contains(key))
            {
                if (!dict.ContainsKey(inputKey))
                {
                    dict.Add(inputKey, new List<string>());
                }
            }
            foreach (var value in inputValue)
            {
                if (input.Contains(value) || value.Contains(input))
                {
                    dict[inputKey].Add(value);
                }
            }
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key}:");
            foreach (var values in item.Value)
            {
                Console.WriteLine($"-{values}");
            }
        }
    }
}