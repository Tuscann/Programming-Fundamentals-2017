using System;
using System.Collections.Generic;
using System.Linq;
public class DefaultValues
{
    public static void Main() // 100/100
    {
        string inputLine = Console.ReadLine();

        Dictionary<string, string> defaultValues = new Dictionary<string, string>();

        while (inputLine != "end")
        {
            string[] tokens = inputLine.Split(" ->".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            string key = tokens[0];
            string value = tokens[1];

            defaultValues[key] = value;

            inputLine = Console.ReadLine();
        }

        inputLine = Console.ReadLine();

        Dictionary<string, string> originalValues = defaultValues
            .Where(x => x.Value != "null")
            .OrderByDescending(x => x.Value.Length)
            .ToDictionary(x => x.Key, x => x.Value);

        Dictionary<string, string> changedValues = defaultValues
            .Where(x => x.Value == "null")
            .ToDictionary(x => x.Key, x => inputLine);
        
        Dictionary<string, string> result = originalValues
            .Concat(changedValues)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (KeyValuePair<string, string> kvp in result)
        {
            Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
        }
    }
}