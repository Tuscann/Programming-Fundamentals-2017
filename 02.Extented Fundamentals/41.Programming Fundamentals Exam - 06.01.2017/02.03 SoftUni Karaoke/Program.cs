using System;
using System.Collections.Generic;
using System.Linq;
public class SoftuniKaraoke
{
    public static void Main() // 100/100
    {
        string[] participants = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
        string[] avaliableSongs = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

        Dictionary<string, List<string>> winners = new Dictionary<string, List<string>>();

        string inputLine = Console.ReadLine();
        while (inputLine != "dawn")
        {
            string[] singerInfo = inputLine.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            string singer = singerInfo[0];
            string song = singerInfo[1];
            string award = singerInfo[2];

            if (participants.Any(s => s == singer) && avaliableSongs.Any(s => s == song))
            {
                if (!winners.ContainsKey(singer))
                {
                    winners.Add(singer, new List<string>());
                }
                winners[singer].Add(award);
            }

            inputLine = Console.ReadLine();
        }

        if (winners.Count == 0)
        {
            Console.WriteLine("No awards");
        }
        else
        {
            foreach (var pair in winners.OrderByDescending(a => a.Value.Distinct().ToList().Count).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Distinct().ToList().Count} awards");
                foreach (string award in pair.Value.Distinct().ToList().OrderBy(n => n))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}