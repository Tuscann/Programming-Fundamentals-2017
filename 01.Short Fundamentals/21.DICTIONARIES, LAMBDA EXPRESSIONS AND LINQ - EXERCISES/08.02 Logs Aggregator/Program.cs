using System;
using System.Collections.Generic;
public class LogsAggregator
{
    public static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        SortedDictionary<string, SortedDictionary<string, int>> userLogs = new SortedDictionary<string, SortedDictionary<string, int>>();
        SortedDictionary<string, int> userAndDuration = new SortedDictionary<string, int>();

        for (int i = 0; i < numbers; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string userIpAdress = input[0];
            string userName = input[1];
            int duration = int.Parse(input[2]);

            if (!userLogs.ContainsKey(userName) && !userAndDuration.ContainsKey(userName))
            {
                userLogs.Add(userName, new SortedDictionary<string, int>());
                userAndDuration.Add(userName, 0);
            }
            if (!userLogs[userName].ContainsKey(userIpAdress))
            {
                userLogs[userName].Add(userIpAdress, 0);
            }

            userLogs[userName][userIpAdress] += duration;
            userAndDuration[userName] += duration;
        }

        foreach (var key in userAndDuration)
        {
            Console.Write($"{key.Key}: {key.Value} ");

            var ips = userLogs[key.Key];
            int count = 0;

            foreach (var ip in ips)
            {
                count++;
                int totalUserIps = ips.Count;

                if (totalUserIps == 1)
                {
                    Console.WriteLine($"[{ip.Key}]");
                }
                else if (count == totalUserIps)
                {
                    Console.WriteLine($"{ip.Key}]");
                }
                else if (count == 1)
                {
                    Console.Write($"[{ip.Key}, ");
                }
                else
                {
                    Console.Write($"{ip.Key}, ");
                }
            }
        }
    }
}