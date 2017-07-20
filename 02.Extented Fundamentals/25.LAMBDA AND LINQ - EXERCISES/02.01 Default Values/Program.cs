using System;
using System.Collections.Generic;
using System.Linq;
public class DefaultValues
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var defaultValues = new Dictionary<string, string>();

        while (inputLine != "end")
        {
            var tokens = inputLine.Split(" ->".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            var key = tokens[0];
            var value = tokens[1];

            defaultValues[key] = value;

            inputLine = Console.ReadLine();
        }

        inputLine = Console.ReadLine();

        var originalValues = defaultValues
            .Where(x => x.Value != "null")
            .OrderByDescending(x => x.Value.Length)
            .ToDictionary(x => x.Key, x => x.Value);

        var changedValues = defaultValues
            .Where(x => x.Value == "null")
            .ToDictionary(x => x.Key, x => inputLine);
        
        var result = originalValues
            .Concat(changedValues)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var kvp in result)
        {
            Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
        }
    }
}