using System;
using System.Collections.Generic;  //100/100
using System.Linq;
public class Event
{
    public int Id { get; set; }

    public string Name { get; set; }

    public List<string> Participants { get; set; }
}

class Program
{
    static void Main() 
    {
        List<Event> result = new List<Event>();
        Dictionary<int, Event> eventsById = new Dictionary<int, Event>();

        while (true)
        {
            string currentLine = Console.ReadLine();

            if (currentLine == "Time for Code")
            {
                break;
            }

            string[] lineParts = currentLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int eventId = 0;

            if (!int.TryParse(lineParts[0], out eventId))
            {
                continue;
            }
            string eventName = null;
            if (lineParts.Length > 1 && lineParts[1].StartsWith("#"))
            {
                eventName = lineParts[1].Trim('#');
            }
            else
            {
                continue;
            }

            List<string> participants = new List<string>();

            if (lineParts.Length > 2)
            {
                participants = lineParts.Skip(2).ToList();

                if (!participants.All(p => p.StartsWith("@")))
                {
                    continue;
                }
            }

            if (eventsById.ContainsKey(eventId))
            {
                if (eventsById[eventId].Name == eventName)
                {
                    Event existingEvent = eventsById[eventId];
                    existingEvent.Participants.AddRange(participants);
                }
                else
                {
                    continue;
                }
            }
            else
            {
                Event newEvent = new Event
                {
                    Id = eventId,
                    Name = eventName,
                    Participants = participants
                };
                result.Add(newEvent);
                eventsById.Add(eventId, newEvent);
            }

            participants.Sort();
        }
        IOrderedEnumerable<Event> sortedEvents = result
            .OrderByDescending(e => e.Participants.Distinct().Count())
            .ThenBy(e => e.Name);

        foreach (Event ev in sortedEvents)
        {
            List<string> distinctParticipants = ev.Participants.Distinct().ToList();

            Console.WriteLine($"{ev.Name} - {distinctParticipants.Count}");
            foreach (string participant in distinctParticipants.OrderBy(p => p))
            {
                Console.WriteLine(participant);
            }
        }
    }
}