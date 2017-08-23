using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        Dictionary<string, double> teams = new Dictionary<string, double> {
                { "Technical",0},
                { "Theoretical",0},
                { "Practical",0}
            };
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            long distance = long.Parse(Console.ReadLine());
            double cargo = double.Parse(Console.ReadLine());
            string team = Console.ReadLine().Trim();

            double earned = cargo * 1000 * 1.5 - 0.7 * distance * 1600 * 2.5;
            teams[team] += earned;
        }
        var winner = teams.OrderByDescending(t => t.Value).First();
        Console.WriteLine("The {0} Trainers win with ${1:F3}.", winner.Key, winner.Value);
    }
}