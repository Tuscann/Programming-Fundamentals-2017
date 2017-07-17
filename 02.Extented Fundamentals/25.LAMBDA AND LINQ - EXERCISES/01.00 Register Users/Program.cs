using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
class Program
{
    static void Main()
    {
        Dictionary<string, DateTime> registeredUsernames = new Dictionary<string, DateTime>();

        string inputLine = Console.ReadLine();

        while (inputLine != "end")
        {
            string[] inputParams = inputLine
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            string username = inputParams[0];
            DateTime registryDate = DateTime.ParseExact(inputParams[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

            registeredUsernames.Add(username, registryDate);

            inputLine = Console.ReadLine();
        }

        Dictionary<string, DateTime> orderedUsernames =
            registeredUsernames
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

        foreach (var kvp in orderedUsernames)
        {
            Console.WriteLine(kvp.Key);
        }
    }
}