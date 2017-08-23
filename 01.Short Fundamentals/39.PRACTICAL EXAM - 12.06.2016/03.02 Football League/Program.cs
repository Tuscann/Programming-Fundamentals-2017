using System;
using System.Collections.Generic;
using System.Linq;
internal static class Program
{
    private const int WinPoints = 3;
    private static readonly SortedDictionary<string, int> TeamRanks = new SortedDictionary<string, int>();
    private static readonly SortedDictionary<string, int> TeamGoals = new SortedDictionary<string, int>();

    public static void Main() // 100/100
    {
        var key = Console.ReadLine();

        string line;
        while ((line = Console.ReadLine()) != null && line != "final")
        {
            var lineParsed = line.Split(null as char[], StringSplitOptions.RemoveEmptyEntries).ToArray();

            var teamAName = lineParsed[0].GetTeamName(key) ?? string.Empty;
            var teamBName = lineParsed[1].GetTeamName(key) ?? string.Empty;
            var score = lineParsed[2].GetScore(null);

            // Apply team ranking points
            if (!TeamRanks.ContainsKey(teamAName))
                TeamRanks[teamAName] = 0;
            if (!TeamRanks.ContainsKey(teamBName))
                TeamRanks[teamBName] = 0;

            if (score[0] > score[1])
            {
                TeamRanks[teamAName] += WinPoints;
            }
            else if (score[0] < score[1])
            {
                TeamRanks[teamBName] += WinPoints;
            }
            else
            {
                TeamRanks[teamAName]++;
                TeamRanks[teamBName]++;
            }

            // Distribute team goals
            if (!TeamGoals.ContainsKey(teamAName))
                TeamGoals[teamAName] = 0;
            if (!TeamGoals.ContainsKey(teamBName))
                TeamGoals[teamBName] = 0;

            TeamGoals[teamAName] += score[0];
            TeamGoals[teamBName] += score[1];
        }


        Console.WriteLine("League standings:");

        var rank = 1;
        foreach (var team in TeamRanks.OrderByDescending(team => team.Value))
            Console.WriteLine($"{rank++}. {team.Key} {team.Value}");

        Console.WriteLine("Top 3 scored goals:");
        foreach (var team in TeamGoals.OrderByDescending(team => team.Value).Take(3))
            Console.WriteLine($"- {team.Key} -> {team.Value}");
    }

    private static string GetTeamName(this string str, string key = " ")
    {
        if (string.IsNullOrEmpty(str))
            return string.Empty;

        var idxStart = str.IndexOf(key, StringComparison.Ordinal) + key.Length;
        var idxEnd = str.IndexOf(key, idxStart, StringComparison.Ordinal);

        return new string(
            str.Substring(idxStart, idxEnd - idxStart)
                .ToUpper().ReverseStr().ToArray());
    }   // GetTeamName()

    private static int[] GetScore(this string str, char[] delim)
    {
        if (delim == null || delim.Length < 1)
            delim = new[] { ':' };

        return str.Split(delim, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
    }   // GetScore()

    private static string ReverseStr(this string str)
    {
        if (string.IsNullOrEmpty(str) || str.Length < 2)
            return str;

        return new string(
            Enumerable.Range(1, str.Length).Select(idx => str[str.Length - idx]).ToArray());
    }   // ReverseStr()
}