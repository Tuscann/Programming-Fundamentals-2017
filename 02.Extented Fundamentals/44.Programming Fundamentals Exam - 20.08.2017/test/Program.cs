using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()  // 100/100
    {
        long traineeCount = long.Parse(Console.ReadLine());
        Dictionary<string, decimal> result = new Dictionary<string, decimal>();
        result.Add("Technical", 0);
        result.Add("Practical", 0);
        result.Add("Theoretical", 0);

        for (int i = 0; i < traineeCount; i++)
        {
            long distanceInMiles = long.Parse(Console.ReadLine());
            decimal cargoInTons = decimal.Parse(Console.ReadLine());
            string teamName = Console.ReadLine();

            decimal profit = cargoInTons * 1000 * 1.5m - distanceInMiles * 1600 * 0.7m * 2.5m;
           
            result[teamName] += profit;
        }
        decimal winnerProfit = result.Values.Max();
        string winnerTeam = result.FirstOrDefault(x => x.Value == winnerProfit).Key;

        Console.WriteLine($"The {winnerTeam} Trainers win with ${winnerProfit:F3}.");
    }
}