using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int lastIndex = int.MinValue;
        var symbols = new Dictionary<char, List<int>>();

        while (true)
        {
            string[] tokens = Console.ReadLine().Split(':');
            if (tokens[0] == "end")
            {
                break;
            }
            char symbol = tokens[0][0];
            List<int> indexesOfChar = tokens[1]
                .Split('/')
                .Select(int.Parse)
                .ToList();

            symbols.Add(symbol, new List<int>(indexesOfChar));

            if (indexesOfChar.Max() > lastIndex)
            {
                lastIndex = indexesOfChar.Max();
            }
        }

        Console.WriteLine(string.Join("", Output(symbols, lastIndex)));
    }

    static List<string> Output(Dictionary<char, List<int>> symbols, int lastIndex)
    {
        List<string> output = new List<string>();

        for (int i = 0; i <= lastIndex; i++)
        {
            output.Add(String.Empty);
        }

        foreach (KeyValuePair<char, List<int>> item in symbols)
        {
            for (int i = 0; i < item.Value.Count; i++)
            {
                output[item.Value[i]] = item.Key.ToString();
            }
        }

        return output;
    }
}