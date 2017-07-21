using System;
using System.Collections.Generic;
using System.Linq;
public class FlattenDictionary
{
    public static void Main()  //100/100
    {
        string inputLine = Console.ReadLine();
        Dictionary<string, Dictionary<string, string>> defaultDictionary = new Dictionary<string, Dictionary<string, string>>();

        while (inputLine != "end")
        {
            string[] tokens = inputLine.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            string firstWord = tokens[0];
            string secondWord = tokens[1];

            if (firstWord != "flatten")
            {
                string thirdWord = tokens[2];

                if (!defaultDictionary.ContainsKey(firstWord))
                {
                    defaultDictionary[firstWord] = new Dictionary<string, string>();
                }
                defaultDictionary[firstWord][secondWord] = thirdWord;
            }
            else
            {
                defaultDictionary[secondWord] = defaultDictionary[secondWord]
                    .ToDictionary(x => x.Key + x.Value, x => "flattend");
            }

            inputLine = Console.ReadLine();
        }

        Dictionary<string, Dictionary<string, string>> result = defaultDictionary
            .OrderByDescending(x => x.Key.Length)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (KeyValuePair<string, Dictionary<string, string>> entry in result)
        {
            Console.WriteLine($"{entry.Key}");
            Dictionary<string, string> orderedInnerDictionary =
                entry.Value
                    .Where(x => x.Value != "flattend")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

            Dictionary<string, string> flattendValues =
                entry.Value
                    .Where(x => x.Value == "flattend")
                    .ToDictionary(x => x.Key, x => x.Value);

            int count = 1;

            foreach (KeyValuePair<string, string> innerEntry in orderedInnerDictionary)
            {
                Console.WriteLine($"{count}. {innerEntry.Key} - {innerEntry.Value}");
                count++;
            }

            foreach (KeyValuePair<string, string> flattenEntry in flattendValues)
            {
                Console.WriteLine($"{count}. {flattenEntry.Key}");
                count++;
            }
        }
    }
}