using System;
using System.Collections.Generic;
using System.Linq;
public class DefaultValues
{
    public static void Main()   // 100/100
    {
        string input = Console.ReadLine();
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        while (input != "end")
        {
            string[] tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = tokens[0];
            string value = tokens[1];
            
            dictionary[name] = value;

            input = Console.ReadLine();
        }

        string defaultValue = Console.ReadLine();

        Dictionary<string, string> withOutChange = dictionary
            .Where(x => x.Value != "null")
            .OrderByDescending(x => x.Value.Length)
            .ToDictionary(x => x.Key, x => x.Value);

        Dictionary<string, string> changeValue = dictionary
            .Where(x => x.Value == "null")
            .ToDictionary(x => x.Key, x => defaultValue);

        foreach (KeyValuePair<string, string> item in withOutChange)
        {
            Console.WriteLine($"{item.Key} <-> {item.Value}");
        }

        foreach (KeyValuePair<string, string> item in changeValue)
        {
            Console.WriteLine($"{item.Key} <-> {item.Value}");
        }
    }
}
