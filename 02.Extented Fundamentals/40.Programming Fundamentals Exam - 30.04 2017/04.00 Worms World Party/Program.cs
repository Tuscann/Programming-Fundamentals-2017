using System;
using System.Collections.Generic;
using System.Linq;

public class WormsWorldParty
{
    public static void Main() // 100/100
    {
        Dictionary<string, Dictionary<string, long>> teams = new Dictionary<string, Dictionary<string, long>>();

        string inputLine = Console.ReadLine();
        while (!inputLine.Equals("quit"))
        {
            string[] tokens = inputLine.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            string teamName = tokens[1];
            string wormName = tokens[0];
            long score = long.Parse(tokens[2].Trim());

            bool hasWorm = true;
            foreach (var kvp in teams)
            {
                if (kvp.Value.ContainsKey(wormName))
                {
                    hasWorm = false;
                }
            }

            if (hasWorm)
            {
                if (!teams.ContainsKey(teamName))
                {
                    teams.Add(teamName, new Dictionary<string, long>());
                }
                teams[teamName].Add(wormName, 0);
                teams[teamName][wormName] += score;
            }

            inputLine = Console.ReadLine();
        }
        int count = 1;

        foreach (var team in teams.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Average()))
        {
            Console.WriteLine($"{count}. Team: {team.Key} - {team.Value.Sum(x => x.Value)}");
            foreach (var worm in team.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"###{worm.Key} : {worm.Value}");
            }
            count++;
        }
    }
}