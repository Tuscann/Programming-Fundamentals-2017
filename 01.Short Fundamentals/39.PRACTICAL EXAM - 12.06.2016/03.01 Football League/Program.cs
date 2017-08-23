using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        string key = Console.ReadLine();
        int position = 1;
        SortedDictionary<string, long> standings = new SortedDictionary<string, long>();
        SortedDictionary<string, long> goalScored = new SortedDictionary<string, long>();
        while (true)
        {
            string matches = Console.ReadLine();
            if (matches == "final") { break; }

            int startFirstTeam = matches.IndexOf(key);
            int endFirstTeam = matches.IndexOf(key, startFirstTeam + key.Length);
            int startSecondTeam = matches.IndexOf(key, endFirstTeam + key.Length);
            int endSecondTeam = matches.IndexOf(key, startSecondTeam + key.Length);
            string firstTeam = matches.Substring(startFirstTeam + key.Length, endFirstTeam - startFirstTeam - key.Length).ToUpper();
            string secondTeam = matches.Substring(startSecondTeam + key.Length, endSecondTeam - startSecondTeam - key.Length).ToUpper();
            firstTeam = Reverse(firstTeam);
            secondTeam = Reverse(secondTeam);

            string[] splitString = matches.Split(' ').ToArray();
            int[] matchResult = splitString.Last().Split(':').Select(int.Parse).ToArray();
            int firstResult = matchResult[0];
            int secondResult = matchResult[1];
            standings = ContainsFirst(standings, firstTeam, firstResult, secondResult);
            standings = ContainsSecond(standings, secondTeam, firstResult, secondResult);
            goalScored = GoalScoredFirst(goalScored, firstTeam, firstResult);
            goalScored = GoalScoredSecond(goalScored, secondTeam, secondResult);
        }
        Console.WriteLine("League standings:");
        foreach (var team in standings.OrderByDescending(x => x.Value))
        {
            Console.WriteLine("{0}. {1} {2}", position, team.Key, team.Value);
            position++;
        }
        Console.WriteLine("Top 3 scored goals:");
        foreach (var team in goalScored.OrderByDescending(x => x.Value).Take(3))
        {
            Console.WriteLine("- {0} -> {1}", team.Key, team.Value);
        }
    }
    static string Reverse(string team)
    {
        char[] teamArray = team.ToArray();
        Array.Reverse(teamArray);
        string reversed = new string(teamArray);
        return reversed;
    }
    static SortedDictionary<string, long> GoalScoredFirst(SortedDictionary<string, long> teams, string firstTeam, int firstResult)
    {
        if (teams.ContainsKey(firstTeam))
        {
            teams[firstTeam] += firstResult;
        }
        else
        {
            teams[firstTeam] = firstResult;
        }
        return teams;
    }
    static SortedDictionary<string, long> GoalScoredSecond(SortedDictionary<string, long> teams, string secondTeam, int secondResult)
    {
        if (teams.ContainsKey(secondTeam))
        {
            teams[secondTeam] += secondResult;
        }
        else
        {
            teams[secondTeam] = secondResult;
        }
        return teams;
    }
    static SortedDictionary<string, long> ContainsFirst(SortedDictionary<string, long> dicitionary, string firstTeam, int firstResult, int secondResult)
    {
        if (dicitionary.ContainsKey(firstTeam))
        {
            if (firstResult > secondResult)
            { dicitionary[firstTeam] += 3; }
            else if (firstResult == secondResult)
            { dicitionary[firstTeam]++; }
        }
        else if (!dicitionary.ContainsKey(firstTeam))
        {
            if (firstResult > secondResult)
            { dicitionary[firstTeam] = 3; }
            else if (firstResult == secondResult)
            { dicitionary[firstTeam] = 1; }
            else if (firstResult < secondResult)
            { dicitionary[firstTeam] = 0; }
        }
        return dicitionary;
    }
    static SortedDictionary<string, long> ContainsSecond(SortedDictionary<string, long> dicitionary, string secondTeam, int firstResult, int secondResult)
    {
        if (dicitionary.ContainsKey(secondTeam))
        {
            if (firstResult < secondResult)
            { dicitionary[secondTeam] += 3; }
            else if (firstResult == secondResult)
            { dicitionary[secondTeam]++; }
        }
        else if (!dicitionary.ContainsKey(secondTeam))
        {
            if (firstResult < secondResult)
            { dicitionary[secondTeam] = 3; }
            else if (firstResult == secondResult)
            { dicitionary[secondTeam] = 1; }
            else if (firstResult > secondResult)
            { dicitionary[secondTeam] = 0; }
        }
        return dicitionary;
    }
}