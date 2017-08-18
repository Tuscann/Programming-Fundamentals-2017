using System;
using System.Collections.Generic;
using System.Linq;
public class Participant
{
    public Participant(string name, HashSet<string> awards)
    {
        this.Name = name;
        this.Awards = awards;
    }

    public string Name { get; set; }

    public HashSet<string> Awards { get; set; }
}

public class SoftUniKaraoke
{
    public static void Main() // 100/100
    {
        string[] participantsNames = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        List<Participant> participants = new List<Participant>();

        foreach (string participantName in participantsNames)
        {
            if (!participants.Any(x => x.Name == participantName))
            {
                Participant currentParticipant = new Participant(participantName, new HashSet<string>());
                participants.Add(currentParticipant);
            }
        }

        IEnumerable<string> songs = Console.ReadLine().Split(',').Select(x => x.Trim());

        string comand = Console.ReadLine();

        while (!comand.ToLower().Equals("dawn"))
        {
            string[] performanceArgs = comand.Split(',').Select(x => x.Trim()).ToArray();
            string participantName = performanceArgs[0];
            string song = performanceArgs[1];
            string award = performanceArgs[2];

            if (participantsNames.Contains(participantName) && songs.Contains(song))
            {
                Participant currentParicipants = participants.First(x => x.Name == participantName);
                currentParicipants.Awards.Add(award);
            }

            comand = Console.ReadLine();
        }

        participants = participants.Where(x => x.Awards.Count > 0).OrderByDescending(x => x.Awards.Count()).ThenBy(x => x.Name).ToList();
        bool hasPerformance = false;

        foreach (Participant participant in participants)
        {
            Console.WriteLine($"{participant.Name}: {participant.Awards.Count()} awards");
            IOrderedEnumerable<string> currentAwards = participant.Awards.OrderBy(x => x);

            foreach (string award in currentAwards)
            {
                Console.WriteLine($"--{award}");
                hasPerformance = true;
            }
        }

        if (!hasPerformance)
        {
            Console.WriteLine("No awards");
        }
    }
}