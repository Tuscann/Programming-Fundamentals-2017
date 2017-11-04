using System;
using System.Linq;
using System.Collections.Generic;   // 100/100

public class Program
{
    public static void Main()
    {
        string inputLine = Console.ReadLine();
        Dictionary<int, Event> eventsBook = new Dictionary<int, Event>();

        while (!inputLine.Equals("Time for Code"))
        {
            string[] inputElements = inputLine.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            if (inputElements[1].Contains('#'))
            {
                int eventId = int.Parse(inputElements[0]);
                char[] eventName = inputElements[1].Skip(1).ToArray();
                string name = string.Join("", eventName);

                if (eventsBook.ContainsKey(eventId) && !eventsBook[eventId].Name.Equals(name))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
                if (eventsBook.ContainsKey(eventId) && eventsBook[eventId].Name.Equals(name))
                {
                    for (int i = 2; i < inputElements.Length; i++)
                    {
                        if (!eventsBook[eventId].partisipant.Contains(inputElements[i]))
                        {
                            eventsBook[eventId].partisipant.Add(inputElements[i]);
                        }
                    }
                }
                else
                {
                    Event currentEvent = new Event();
                    currentEvent.Name = name;

                    for (int i = 2; i < inputElements.Length; i++)
                    {
                        if (inputElements[i].Contains('@'))
                        {
                            if (!currentEvent.partisipant.Contains(inputElements[i]))
                            {
                                currentEvent.partisipant.Add(inputElements[i]);
                            }
                        }
                    }
                    eventsBook[eventId] = currentEvent;
                }
            }
            inputLine = Console.ReadLine();
        }
        foreach (var evenT in eventsBook.OrderByDescending(v => v.Value.partisipant.Count).ThenBy(v => v.Value.Name).ToDictionary(x => x.Key, x => x.Value))
        {
            Console.WriteLine($"{evenT.Value.Name} - { evenT.Value.partisipant.Count}");
            foreach (var item in evenT.Value.partisipant.OrderBy(x => x))
            {
                Console.WriteLine(item);
            }
        }
    }
}

public class Event
{

    public Event()
    {
        this.partisipant = new List<string>();
    }
    public List<string> partisipant { get; set; }
    public string Name { get; set; }
}
