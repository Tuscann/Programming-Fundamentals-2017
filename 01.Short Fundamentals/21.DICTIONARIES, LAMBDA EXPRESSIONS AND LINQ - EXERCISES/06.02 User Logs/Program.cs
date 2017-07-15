using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();

        var userLogs = new SortedDictionary<string, Dictionary<string, int>>();
        while (!input.Equals("end"))
        {
            string[] log = input.Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string username = log[5];
            string IP = log[1];
            int counter = 1;

            if (!userLogs.ContainsKey(username))
            {
                userLogs.Add(username, new Dictionary<string, int>());
            }
            if (!userLogs[username].ContainsKey(IP))
            {
                userLogs[username].Add(IP, counter);
            }
            else
            {
                userLogs[username][IP]++;
            }
            input = Console.ReadLine();
        }
        foreach (var user in userLogs)
        {
            Console.WriteLine($"{user.Key}: ");
            foreach (var log in user.Value)
            {
                if (log.Key != user.Value.Keys.Last())
                {
                    Console.Write($"{log.Key} => {log.Value}, ");
                }
                else
                {
                    Console.WriteLine($"{log.Key} => {log.Value}.");
                }
            }
        }
    }
}