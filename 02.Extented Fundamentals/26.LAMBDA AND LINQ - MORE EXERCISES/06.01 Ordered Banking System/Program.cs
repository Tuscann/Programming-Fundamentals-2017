using System;
using System.Collections.Generic;
using System.Linq;
public class OrderedBankingSystem
{
    public static void Main()
    {
        var onlineBanking = new Dictionary<string, Dictionary<string, decimal>>();
        var enterData = Console.ReadLine().Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

        while (enterData[0] != "end")
        {
            if (!onlineBanking.ContainsKey(enterData[0]))
            {
                onlineBanking[enterData[0]] = new Dictionary<string, decimal>();
            }
            if (!onlineBanking[enterData[0]].ContainsKey(enterData[1]))
            {
                onlineBanking[enterData[0]][enterData[1]] = 0;
            }
            onlineBanking[enterData[0]][enterData[1]] += decimal.Parse(enterData[2]);

            enterData = Console.ReadLine().Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        onlineBanking.OrderByDescending(bank => bank.Value.Sum(acount => acount.Value))
            .ThenByDescending(bank => bank.Value.Max(acount => acount.Value)).ToList()
            .ForEach(bank => bank.Value.OrderByDescending(acount => acount.Value).ToList()
                .ForEach(acount => Console.WriteLine($"{acount.Key} -> {acount.Value} ({bank.Key})")));
    }
}