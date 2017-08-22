using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
public class NSA
{
    public static void Main() // 100/100
    {
        Dictionary<string, Dictionary<string, int>> spysByCountryAndDaysAway = new Dictionary<string, Dictionary<string, int>>();
        for (int infiniatly = 0; ; infiniatly++)
        {
            string countrySpyDaysAway = Console.ReadLine();
            if (countrySpyDaysAway == "quit") { break; }

            string patern = @"^(?<country>[a-zA-Z0-9-_]+)\s->\s(?<spy>[a-zA-Z0-9-_]+)\s->\s(?<days>[0-9]+)$";
            Regex splittedData = new Regex(patern);
            Match matches = splittedData.Match(countrySpyDaysAway);

            string country = matches.Groups["country"].Value;
            string spyName = matches.Groups["spy"].Value;
            int daysAway = Convert.ToInt32(matches.Groups["days"].Value);

            if (!spysByCountryAndDaysAway.ContainsKey(country))
            {
                spysByCountryAndDaysAway[country] = new Dictionary<string, int>();
            }
            if (!spysByCountryAndDaysAway[country].ContainsKey(spyName))
            {
                spysByCountryAndDaysAway[country][spyName] = 0;
            }
            spysByCountryAndDaysAway[country][spyName] = daysAway;
        }

        foreach (KeyValuePair<string, Dictionary<string, int>> country in spysByCountryAndDaysAway.OrderByDescending(x => x.Value.Count))
        {
            Console.WriteLine($"Country: {country.Key}");
            foreach (KeyValuePair<string, int> spyDaysAway in country.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"**{spyDaysAway.Key} : {spyDaysAway.Value}");
            }
        }
    }
}