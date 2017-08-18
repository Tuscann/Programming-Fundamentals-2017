using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        Dictionary<string, int> standings = new Dictionary<string, int>();
        Dictionary<string, int> teamGoals = new Dictionary<string, int>();

        string key = Console.ReadLine();
        string line = Console.ReadLine();
        while (!line.Equals("final"))
        {
            string[] lineArgs = line.Split();
            string firstTeamName = GetTeamName(lineArgs[0], key);
            string secondTeamName = GetTeamName(lineArgs[1], key);

            string[] score = lineArgs[2].Split(':');
            int firstTeamGoals = int.Parse(score[0]);
            int secondTeamGoals = int.Parse(score[1]);

            if (firstTeamGoals > secondTeamGoals)
            {
                AddScoreToTeam(standings, firstTeamName, 3);
                AddScoreToTeam(standings, secondTeamName, 0);
            }
            else if (firstTeamGoals < secondTeamGoals)
            {
                AddScoreToTeam(standings, firstTeamName, 0);
                AddScoreToTeam(standings, secondTeamName, 3);
            }
            else
            {
                AddScoreToTeam(standings, firstTeamName, 1);
                AddScoreToTeam(standings, secondTeamName, 1);
            }

            AddScoreToTeam(teamGoals, firstTeamName, firstTeamGoals);
            AddScoreToTeam(teamGoals, secondTeamName, secondTeamGoals);

            line = Console.ReadLine();
        }

        Console.WriteLine("League standings:");
        var sorted = standings.OrderByDescending(t => t.Value).ThenBy(t => t.Key);
        int count = 1;
        foreach (var team in sorted)
        {
            Console.WriteLine($"{count}. {team.Key} {team.Value}");
            count++;
        }

        Console.WriteLine("Top 3 scored goals:");
        var sortedGoals = teamGoals.OrderByDescending(t => t.Value).ThenBy(t => t.Key).Take(3);
        foreach (var team in sortedGoals)
        {
            Console.WriteLine($"- {team.Key} -> {team.Value}");
            count++;
        }
    }

    private static void AddScoreToTeam(Dictionary<string, int> standings, string firstTeamName, int firstTeamScore)
    {
        if (!standings.ContainsKey(firstTeamName))
        {
            standings.Add(firstTeamName, 0);
        }

        standings[firstTeamName] += firstTeamScore;
    }

    private static string GetTeamName(string teamName, string key)
    {
        int firstIndex = teamName.IndexOf(key) + key.Length;
        int secondIndex = teamName.LastIndexOf(key);
        int length = secondIndex - firstIndex;
        string name = teamName.Substring(firstIndex, length);
        return string.Join("", name.ToUpper().Reverse());
    }
}