using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUniKaraoke
{
    public static void Main() // 100/100
    {
        string[] allParticipants = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        string[] allSongs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> songs = new List<string>();
        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

        foreach (string song in allSongs)
        {
            songs.Add(song.Trim());
        }

        string performance = Console.ReadLine();
        
        while (performance != "dawn")
        {
            string[] tokens = performance.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            string participant = tokens[0].Trim();
            string song = tokens[1].Trim();
            string award = tokens[2].Trim();

            if (allParticipants.Contains(participant))
            {
                if (songs.Contains(song))
                {
                    if (!result.ContainsKey(participant))
                    {
                        result[participant] = new List<string>();
                    }

                    if (!result[participant].Contains(award))
                    {
                        result[participant].Add(award);
                    }
                }
            }

            performance = Console.ReadLine();
        }

        if (result.Count == 0)
        {
            Console.WriteLine("No awards");
        }
        else
        {
            foreach (var participant in result.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");

                List<string> awards = participant.Value.OrderBy(x => x).ToList();

                if (awards.Count > 0)
                {
                    foreach (string award in awards)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
                else
                {
                    Console.WriteLine("No awards");
                }
            }
        }
    }
}