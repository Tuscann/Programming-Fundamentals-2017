using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
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

            if (!participants.Any(s => s == singer) || !avaliableSongs.Any(s => s == song))
            {
                inputLine = Console.ReadLine();

                continue;
            }

            if (!winners.ContainsKey(singer))
            {
                winners.Add(singer, new List<string>());
            }

            winners[singer].Add(award);

            inputLine = Console.ReadLine();
        }

        if (winners.Count == 0)
        {
            Console.WriteLine("No awards");

            return;
        }

        foreach (KeyValuePair<string, List<string>> pair in winners.OrderByDescending(a => a.Value.Distinct().ToList().Count)
                                                            .ThenBy(n => n.Key))
        {
            List<string> awards = pair.Value.Distinct().ToList();

            Console.WriteLine($"{pair.Key}: {awards.Count} awards");
            foreach (string award in awards.OrderBy(n => n))
            {
                Console.WriteLine($"--{award}");
            }
        }
    }
}
