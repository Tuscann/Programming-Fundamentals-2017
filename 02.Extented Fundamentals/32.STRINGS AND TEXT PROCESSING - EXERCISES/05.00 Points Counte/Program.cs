using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()  // 100/100
    {
        string inputData = Console.ReadLine();
        var teams = new Dictionary<string, Dictionary<string, int>>();
        string teamName = string.Empty;
        string playerName = string.Empty;


        while (inputData != "Result")
        {
            inputData = inputData
                .Replace("@", string.Empty)
                .Replace("%", string.Empty)
                .Replace("$", string.Empty)
                .Replace("*", string.Empty);

            string[] tokens = inputData.Split('|');

            if (tokens[0].Last() > 96)
            {
                teamName = tokens[1];
                playerName = tokens[0];
            }
            else
            {
                teamName = tokens[0];
                playerName = tokens[1];
            }
            int points = int.Parse(tokens[2]);

            if (!teams.ContainsKey(teamName))
            {
                teams.Add(teamName, new Dictionary<string, int>());
            }

            teams[teamName][playerName] = points;

            inputData = Console.ReadLine();
        }

        foreach (var team in teams.OrderByDescending(x => x.Value.Values.Sum()))
        {
            Console.WriteLine($"{team.Key} => {team.Value.Values.Sum()}");

            foreach (var player in team.Value.OrderByDescending(x => x.Value).Take(1))
            {
                Console.WriteLine($"Most points scored by {player.Key}");
            }
        }
    }
}