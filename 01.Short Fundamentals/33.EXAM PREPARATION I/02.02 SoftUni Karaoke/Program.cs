using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> participantsInput = Console.ReadLine().Split(',').Select(p => p.Trim()).ToList();
        List<string> songsInput = Console.ReadLine().Split(',').Select(s => s.Trim()).ToList();

        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

        string line = Console.ReadLine();
        while (line != "dawn")
        {
            List<string> performance = line.Split(',').Select(p => p.Trim()).ToList();

            string participant = performance[0];
            string song = performance[1];
            string award = performance[2];

            if (participantsInput.Contains(participant) && songsInput.Contains(song))
            {
                if (!result.ContainsKey(participant))
                {
                    result[participant] = new List<string>();
                }
                List<string> awards = result[participant];
                if (!awards.Contains(award))
                {
                    awards.Add(award);
                }
            }
            line = Console.ReadLine();
        }
        if (result.Any())
        {
            foreach (KeyValuePair<string, List<string>> keyValuePair in result.OrderByDescending(p => p.Value.Count).ThenBy(n => n.Key))
            {
                if (keyValuePair.Key.Any())
                {
                    string participant = keyValuePair.Key;
                    List<string> awards = keyValuePair.Value;
                    Console.WriteLine($"{participant}: {awards.Count} awards");
                    foreach (string award in awards.OrderBy(n => n))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("No awards");
        }
    }
}