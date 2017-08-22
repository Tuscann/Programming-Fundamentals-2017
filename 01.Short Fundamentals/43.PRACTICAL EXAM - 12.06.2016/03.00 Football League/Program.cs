using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        string separator = Console.ReadLine();

        string textMatches = Console.ReadLine();

        Dictionary<string, long> countries = new Dictionary<string, long>();
        Dictionary<string, long> countriesBestScores = new Dictionary<string, long>();

        while (!textMatches.Contains("final"))
        {
            string[] splitString = textMatches.Split(' ').ToArray();
            long[] matchResult = splitString.Last().Split(':').Select(long.Parse).ToArray();
            long firstTeamScore = matchResult[0];
            long secondTeamScore = matchResult[1];

            int firstIndex = textMatches.IndexOf(separator);
            List<string> teamClean = new List<string>();

            while (firstIndex >= 0)
            {
                int secondIndex = textMatches.Substring(firstIndex + separator.Length - 1).IndexOf(separator);

                string toUpperLetters = textMatches.Substring(firstIndex + separator.Length, secondIndex - 1).ToUpper();
                char[] reverseTheTeam = toUpperLetters.ToCharArray();
                Array.Reverse(reverseTheTeam);
                teamClean.Add(string.Join("", reverseTheTeam));

                string newText = textMatches.Remove(firstIndex, secondIndex + separator.Length + 1).Trim();

                textMatches = newText;

                firstIndex = textMatches.IndexOf(separator);
            }

            GetStats(countries, countriesBestScores, firstTeamScore, secondTeamScore, teamClean);

            textMatches = Console.ReadLine();
        }

        Console.WriteLine("League standings:");
        int count = 0;
        foreach (var position in countries.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            string county = position.Key;
            long score = position.Value;
            count++;
            Console.WriteLine($"{count}. {county} {score}");
        }

        Console.WriteLine("Top 3 scored goals:");
        foreach (var stat in countriesBestScores.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
        {
            string county = stat.Key;
            long goals = stat.Value;
            Console.WriteLine($"- {county} -> {goals}");
        }

    }

    private static void GetStats(Dictionary<string, long> countries, Dictionary<string, long> countriesBestScores, long firstTeamScore, long secondTeamScore, List<string> teamClean)
    {
        if (firstTeamScore > secondTeamScore)
        {
            if (countries.Keys.Contains(teamClean[0]))
            {
                countries[teamClean[0]] += 3;
                countriesBestScores[teamClean[0]] += firstTeamScore;
            }
            else
            {
                countries.Add(teamClean[0], 3);
                countriesBestScores.Add(teamClean[0], firstTeamScore);
            }
            if (countries.Keys.Contains(teamClean[1]))
            {
                countries[teamClean[1]] += 0;
                countriesBestScores[teamClean[1]] += secondTeamScore;
            }
            else
            {
                countries.Add(teamClean[1], 0);
                countriesBestScores.Add(teamClean[1], secondTeamScore);
            }
        }
        else if (firstTeamScore < secondTeamScore)
        {
            if (countries.Keys.Contains(teamClean[0]))
            {
                countries[teamClean[0]] += 0;
                countriesBestScores[teamClean[0]] += firstTeamScore;
            }
            else
            {
                countries.Add(teamClean[0], 0);
                countriesBestScores.Add(teamClean[0], firstTeamScore);
            }
            if (countries.Keys.Contains(teamClean[1]))
            {
                countries[teamClean[1]] += 3;
                countriesBestScores[teamClean[1]] += secondTeamScore;
            }
            else
            {
                countries.Add(teamClean[1], 3);
                countriesBestScores.Add(teamClean[1], secondTeamScore);
            }
        }
        else
        {
            if (countries.Keys.Contains(teamClean[0]))
            {
                countries[teamClean[0]] += 1;
                countriesBestScores[teamClean[0]] += firstTeamScore;
            }
            else
            {
                countries.Add(teamClean[0], 1);
                countriesBestScores.Add(teamClean[0], firstTeamScore);
            }
            if (countries.Keys.Contains(teamClean[1]))
            {
                countries[teamClean[1]] += 1;
                countriesBestScores[teamClean[1]] += secondTeamScore;
            }
            else
            {
                countries.Add(teamClean[1], 1);
                countriesBestScores.Add(teamClean[1], secondTeamScore);
            }
        }
    }
}