using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split('=', ' ').ToList();
        SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();

        while (true)
        {
            if (input[0] == "end")
            {
                break;
            }
            string ip = input[1];
            string user = input[5];

            if (!users.ContainsKey(user))
            {
                users.Add(user, new Dictionary<string, int>());
            }
            if (!users[user].ContainsKey(ip))
            {
                users[user].Add(ip, 0);
            }
            users[user][ip] += 1;
            input = Console.ReadLine().Split('=', ' ').ToList();
        }
        var orderedUsers = users.OrderBy(x => x.Key).ToList();

        foreach (var kvp in orderedUsers)
        {
            Console.WriteLine(kvp.Key + ":");
            int counter = 1;
            foreach (var ipAndTimes in kvp.Value)
            {
                if (kvp.Value.Count == counter)
                {
                    Console.WriteLine($"{ipAndTimes.Key} => {ipAndTimes.Value}.");
                    break;
                }
                Console.Write($"{ipAndTimes.Key} => {ipAndTimes.Value}, ");
                counter++;
            }
        }
    }
}