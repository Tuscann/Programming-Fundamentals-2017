using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedDictionary<string, SortedDictionary<string, int>> usersLogs = new SortedDictionary<string, SortedDictionary<string, int>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            string currentIp = input[0];
            string currentName = input[1];
            int currentDuration = int.Parse(input[2]);

            if (!usersLogs.ContainsKey(currentName))
            {
                usersLogs[currentName] = new SortedDictionary<string, int>();
            }
            if (!usersLogs[currentName].ContainsKey(currentIp))
            {
                usersLogs[currentName][currentIp] = 0;
            }
            usersLogs[currentName][currentIp] += currentDuration;
        }

        foreach (var name in usersLogs)
        {
            Console.Write($"{name.Key}: {name.Value.Values.Sum()}");
            string toPrint = " [";

            foreach (var item in name.Value)
            {
                string currIp = item.Key;
                toPrint += currIp + ", ";
            }

            toPrint = toPrint.Substring(0, toPrint.Length - 2);
            toPrint += "]";
            Console.WriteLine(toPrint);
        }
    }
}