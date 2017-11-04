using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;  // 100/100

class RoliTheCoder
{
    static void Main()
    {
        Dictionary<int, string> eventsIds = new Dictionary<int, string>();
        Dictionary<string, List<string>> events = new Dictionary<string, List<string>>();

        string pattern = @"([0-9]+)\s+#\s*(\w+)\s*";

        Regex rgx1 = new Regex(pattern);
        string command = Console.ReadLine();

        while (command != "Time for Code")
        {
            if (rgx1.IsMatch(command))
            {
                Match match = rgx1.Match(command);
                int ID = int.Parse(match.Groups[1].Value.Trim());
                string eventName = match.Groups[2].Value.Trim();
                string temp = Regex.Replace(command, @"\s+", "");
                List<string> people = new List<string>();
                if (temp.Contains("@"))
                {
                    int startIndex = temp.IndexOf('@');
                    temp = temp.Substring(startIndex);
                    people = temp.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }

                if (eventsIds.ContainsKey(ID))
                {
                    if (eventsIds[ID] == eventName)
                    {
                        if (events.ContainsKey(eventName))
                        {
                            events[eventName].AddRange(people);
                        }
                        else
                        {
                            events.Add(eventName, people);
                        }
                    }
                }
                else
                {
                    eventsIds.Add(ID, eventName);
                    events.Add(eventName, people);
                }
            }
            command = Console.ReadLine();
        }


        foreach (var eve in events.OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(z => z.Key))
        {
            Console.WriteLine($"{eve.Key} - {eve.Value.Distinct().Count()}");
            foreach (var person in eve.Value.Distinct().OrderBy(x => x))
            {
                Console.WriteLine($"@{person}");
            }
        }
    }
}
