using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()   //100/100
    {
        Dictionary<string, Dictionary<string, int>> Data = new Dictionary<string, Dictionary<string, int>>();
        string input = Console.ReadLine();
        while (input != "stop the game")
        {
            string[] inputTokens = input.Split('|');
            string name = inputTokens[0];
            string Team = inputTokens[1];
            int points = int.Parse(inputTokens[2]);
            if (!Data.ContainsKey(Team))
            {
                Data[Team] = new Dictionary<string, int>();
            }
            if (Data[Team].Values.Count == 3)
            {
                input = Console.ReadLine();
                continue;
            }
            Data[Team][name] = points;
            input = Console.ReadLine();
        }
        int count = 0;
        foreach (KeyValuePair<string, Dictionary<string, int>> comp in Data.Where(x => x.Value.Count >= 3).OrderByDescending(x => x.Value.Values.Sum()))
        {
            count++;
            Console.WriteLine("{0}. {1}; Players:", count, comp.Key);
            foreach (KeyValuePair<string, int> player in comp.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"###{player.Key}: {player.Value}");
            }

        }
    }
}