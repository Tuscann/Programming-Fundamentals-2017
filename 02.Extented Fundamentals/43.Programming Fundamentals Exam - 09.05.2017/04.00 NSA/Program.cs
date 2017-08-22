using System;
using System.Collections.Generic;
using System.Linq;
class NSA
{
    static void Main()   // 100/100
    {
        var allSpies = new Dictionary<string, Dictionary<string, int>>();

        string inputLine = Console.ReadLine();

        while (inputLine != "quit")
        {
            string[] inputParameters = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string currentCountry = inputParameters[0];
            string currentSpy = inputParameters[1];
            int currSpyDaysService = int.Parse(inputParameters[2]);

            if (!allSpies.ContainsKey(currentCountry))
            {
                allSpies[currentCountry] = new Dictionary<string, int>();
            }
            if (!allSpies[currentCountry].ContainsKey(currentSpy))
            {
                allSpies[currentCountry][currentSpy] = 0;
            }

            allSpies[currentCountry][currentSpy] = currSpyDaysService;
            
            inputLine = Console.ReadLine();
        }

        foreach (var country in allSpies.OrderByDescending(c => c.Value.Count))
        {
            Console.WriteLine($"Country: {country.Key}");

            foreach (var spy in country.Value.OrderByDescending(s => s.Value))
            {
                Console.WriteLine($"**{spy.Key} : {spy.Value}");
            }
        }
    }
}