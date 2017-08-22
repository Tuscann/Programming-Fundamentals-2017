using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class FootballStandings
{
    static void Main() // 100/100
    {
        string key = Regex.Escape(Console.ReadLine());

        Dictionary<string, long> teamScores = new Dictionary<string, long>();
        Dictionary<string, long> teamGoals = new Dictionary<string, long>();

        string pattern = string.Format(key + @"([a-zA-Z]*)" + key + @".*" + key + @"([a-zA-Z]*)" + key + @".*[^\d]" + @"(\d+):(\d+)");
        Regex rgx1 = new Regex(pattern);

        string infoLine = Console.ReadLine();

        while (infoLine != "final")
        {
            Match matchInfo = rgx1.Match(infoLine);

            string teamOne = GetTeamName(matchInfo.Groups[1].Value.ToUpper());
            string teamTwo = GetTeamName(matchInfo.Groups[2].Value.ToUpper());
            long scoreTeamOne = long.Parse(matchInfo.Groups[3].Value);
            long scoreTeamTwo = long.Parse(matchInfo.Groups[4].Value);

            if (teamGoals.ContainsKey(teamOne))
            {
                teamGoals[teamOne] += scoreTeamOne;
            }
            else
            {
                teamGoals.Add(teamOne, scoreTeamOne);
            }
            if (teamGoals.ContainsKey(teamTwo))
            {
                teamGoals[teamTwo] += scoreTeamTwo;
            }
            else
            {
                teamGoals.Add(teamTwo, scoreTeamTwo);
            }

            if (scoreTeamOne > scoreTeamTwo)
            {
                if (teamScores.ContainsKey(teamOne))
                {
                    teamScores[teamOne] += 3;
                }
                else
                {
                    teamScores.Add(teamOne, 3);
                }
                if (teamScores.ContainsKey(teamTwo))
                {
                    teamScores[teamTwo] += 0;
                }
                else
                {
                    teamScores.Add(teamTwo, 0);
                }
            }
            else if (scoreTeamOne < scoreTeamTwo)
            {
                if (teamScores.ContainsKey(teamOne))
                {
                    teamScores[teamOne] += 0;
                }
                else
                {
                    teamScores.Add(teamOne, 0);
                }
                if (teamScores.ContainsKey(teamTwo))
                {
                    teamScores[teamTwo] += 3;
                }
                else
                {
                    teamScores.Add(teamTwo, 3);
                }
            }
            else
            {
                if (teamScores.ContainsKey(teamOne))
                {
                    teamScores[teamOne] += 1;
                }
                else
                {
                    teamScores.Add(teamOne, 1);
                }
                if (teamScores.ContainsKey(teamTwo))
                {
                    teamScores[teamTwo] += 1;
                }
                else
                {
                    teamScores.Add(teamTwo, 1);
                }
            }

            infoLine = Console.ReadLine();
        }
        int place = 1;
        Console.WriteLine("League standings:");
        foreach (var team in teamScores.OrderByDescending(x => x.Value).ThenBy(z => z.Key))
        {
            Console.WriteLine($"{place}. {team.Key} {team.Value}");
            place++;
        }

        Console.WriteLine("Top 3 scored goals:");
        foreach (var topTeam in teamGoals.OrderByDescending(x => x.Value).ThenBy(z => z.Key).Take(3))
        {
            Console.WriteLine($"- {topTeam.Key} -> {topTeam.Value}");
        }
    }

    private static string GetTeamName(string value)
    {
        string name = string.Join("", value.Reverse());
        return name;
    }
}