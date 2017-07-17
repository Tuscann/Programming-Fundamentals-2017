using System;
using System.Collections.Generic;
using System.Linq;
class Population_Counter
{
    static void Main()
    {
        SortedDictionary<string, SortedDictionary<string, int>> dict = new SortedDictionary<string, SortedDictionary<string, int>>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] curentLine = Console.ReadLine().Split(' ').ToArray();

            string user = curentLine[1];
            string ip = curentLine[0];
            int duration = int.Parse(curentLine[2]);

            if (!dict.ContainsKey(user))
            {
                dict[user] = new SortedDictionary<string, int>();
            }
            if (!dict[user].ContainsKey(ip))
            {
                dict[user][ip] = 0;
            }
            dict[user][ip] += duration;
        }
        foreach (KeyValuePair<string, SortedDictionary<string, int>> name in dict)
        {
            string names = name.Key;
            int totalDuration = name.Value.Values.Sum();
            List<string> ipsList = name.Value.Keys.ToList();

            Console.WriteLine("{0}: {1} [{2}]", names, totalDuration, string.Join(", ", ipsList));
        }
    }
}