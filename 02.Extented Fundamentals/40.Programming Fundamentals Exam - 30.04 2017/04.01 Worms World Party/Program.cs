using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class WormsWorldParty
{
    public static void Main() // 100/100
    {
        string input = Console.ReadLine();
        Dictionary<string, Dictionary<string, long>> worms = new Dictionary<string, Dictionary<string, long>>();

        string pattern = @"([A-z\d\s]*)\s\-\>\s([A-z\d\s]*)\s\-\>\s(\d+)";
        Regex regex = new Regex(pattern);

        while (input != "quit")
        {
            if (regex.IsMatch(input))
            {
                MatchCollection matches = regex.Matches(input);
                string wormName = string.Empty;
                string wormTeam = string.Empty;
                long wormScore = 0L;

                foreach (Match match in matches)
                {
                    wormName = match.Groups[1].Value;
                    wormTeam = match.Groups[2].Value;
                    wormScore = long.Parse(match.Groups[3].Value);
                }

                if (worms.Values.Any(x => x.Keys.Any(y => y == wormName)))
                {
                    break;
                }

                if (!worms.ContainsKey(wormTeam))
                {
                    worms[wormTeam] = new Dictionary<string, long>();
                }

                if (!worms[wormTeam].ContainsKey(wormName))
                {
                    worms[wormTeam][wormName] = 0;
                }

                worms[wormTeam][wormName] += wormScore;
            }

            input = Console.ReadLine();
        }

        int count = 1;

        foreach (var team in worms.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Average()))
        {
            Console.WriteLine($"{count}. Team: {team.Key} - {team.Value.Values.Sum()}");
            count++;

            foreach (var worm in team.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"###{worm.Key} : {worm.Value}");
            }
        }
    }
}