using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03_Football_League
{
    class Program
    {
        static void Main() // 80/100
        {
            string key = Console.ReadLine();

            StringBuilder newKey = new StringBuilder();

            char[] weirdSymbols = new char[] { '?', '+', '*', '^', '$', '|', '(', ')', '[', ']', '{', '}', '.', '\\', '-' };

            for (int cycle = 0; cycle < key.Length; cycle++)
            {
                if (weirdSymbols.Contains(key[cycle]))
                {
                    newKey.Append("\\");
                }
                newKey.Append(key[cycle]);
            }

            List<TeamPointsGoals> TeamPointsGoals = new List<TeamPointsGoals>();

            Regex toRegex = new Regex(@"(" + newKey + @")([A-Za-z]+)(" + newKey + @")");

            string inputLine = Console.ReadLine();

            while (inputLine != "final")
            {
                string[] toGetTheResult = inputLine.Split();
                int[] goalsInTheResult = toGetTheResult.Last().Split(':').Select(int.Parse).ToArray();

                int firstTeamGoal = goalsInTheResult[0];
                int secondTeamGoal = goalsInTheResult[1];

                bool firstWins = false;
                bool secondWins = false;
                bool drawMatch = false;

                if (firstTeamGoal > secondTeamGoal)
                {
                    firstWins = true;
                }
                else if (firstTeamGoal < secondTeamGoal)
                {
                    secondWins = true;
                }
                else
                {
                    drawMatch = true;
                }

                MatchCollection teamNames = toRegex.Matches(inputLine);

                int count = 1;

                foreach (Match match in teamNames)
                {
                    string currentTeam = match.Groups[2].Value.ToString().ToUpper();

                    char[] reverseTheTeam = currentTeam.ToCharArray();

                    Array.Reverse(reverseTheTeam);

                    currentTeam = string.Join("", reverseTheTeam);

                    if (count == 1)
                    {
                        ForTheSeparateTeam(TeamPointsGoals, firstTeamGoal, firstWins, drawMatch, currentTeam);
                    }
                    else if (count == 2)
                    {
                        int parameter = 0;
                        if (secondWins == true)
                        {
                            parameter = 3;
                        }
                        else if (drawMatch == true)
                        {
                            parameter = 1;
                        }
                        CalculateTeamScoreAndGoals(TeamPointsGoals, secondTeamGoal, currentTeam, parameter);

                    }
                    count++;
                }

                inputLine = Console.ReadLine();
            }
            int countToTheLast = 1;
            Console.WriteLine("League standings:");
            foreach (var team in TeamPointsGoals.OrderByDescending(x => x.points).ThenBy(x => x.teamName))
            {
                Console.WriteLine(countToTheLast + ". " + team.teamName + " " + team.points);
                countToTheLast++;
            }
            Console.WriteLine("Top 3 scored goals:");
            int countToThree = 0;
            foreach (var team in TeamPointsGoals.OrderByDescending(x => x.goals).ThenBy(x => x.teamName))
            {
                if (countToThree == 3)
                {
                    break;
                }
                Console.WriteLine("- " + team.teamName + " -> " + team.goals);
                countToThree++;
            }
        }

        private static void ForTheSeparateTeam(List<TeamPointsGoals> TeamPointsGoals, int firstTeamGoal, bool firstWins, bool drawMatch, string currentTeam)
        {
            int parameter = 0;
            if (firstWins == true)
            {
                parameter = 3;
            }
            else if (drawMatch == true)
            {
                parameter = 1;
            }
            CalculateTeamScoreAndGoals(TeamPointsGoals, firstTeamGoal, currentTeam, parameter);
        }

        private static void CalculateTeamScoreAndGoals(List<TeamPointsGoals> TeamPointsGoals, int firstTeamGoal, string currentTeam, int param)
        {
            bool hasTeam = false;
            foreach (var team in TeamPointsGoals)
            {
                if (team.teamName == currentTeam)
                {
                    team.goals += firstTeamGoal;
                    team.points += param;
                    hasTeam = true;
                    break;
                }
            }

            if (hasTeam == false)
            {
                TeamPointsGoals currTeam = new TeamPointsGoals();

                currTeam.teamName = currentTeam;
                currTeam.points = param;
                currTeam.goals = firstTeamGoal;

                TeamPointsGoals.Add(currTeam);
            }
        }
    }
}

class TeamPointsGoals
{
    public string teamName { get; set; }
    public int points { get; set; }
    public long goals { get; set; }
}