using System;
using System.Collections.Generic;
using System.Linq;

public class FlattenDictionary
{
    static int counter = 1;
    static string key = string.Empty;
    static string inerKey = string.Empty;
    static string inerValue = string.Empty;

    static Dictionary<string, Dictionary<string, string>> flattedCollection =
        new Dictionary<string, Dictionary<string, string>>();

    public static void Main()
    {
        ReadNextLinesUntillEnd(Console.ReadLine());
        PrintByGivenOrder();
    }

    static void ReadNextLinesUntillEnd(string unsplited)
    {
        if (unsplited == "end")
        {
            return;
        }
        if (unsplited.Contains("flatten"))
        {
            FlattInerData(unsplited);
            ReadNextLinesUntillEnd(Console.ReadLine());
        }
        else
        {
            DivideAndRule(unsplited);
            AddOrUpdateToCollection();
            ReadNextLinesUntillEnd(Console.ReadLine());
        }
    }

    private static void FlattInerData(string unsplited)
    {
        key = unsplited.Split(' ')[1];
        inerValue = "flatten";
        var last = flattedCollection[key];
        flattedCollection[key] = new Dictionary<string, string>();
        foreach (var item in last)
        {
            inerKey = item.Key + item.Value;
            AddOrUpdateToCollection();
        }
    }

    static void DivideAndRule(string unsplited)
    {
        var splited = unsplited.Split(' ');
        key = splited[0];
        inerKey = splited[1];
        inerValue = splited[2];
    }

    static void AddOrUpdateToCollection()
    {
        if (!flattedCollection.ContainsKey(key))
        {
            flattedCollection[key] = new Dictionary<string, string>();
        }
        if (!flattedCollection[key].ContainsKey(inerKey))
        {
            flattedCollection[key][inerKey] = string.Empty;
        }
        flattedCollection[key][inerKey] = inerValue;
    }

    static void PrintByGivenOrder()
    {
        foreach (var item in flattedCollection.OrderByDescending(x => x.Key.Length))
        {
            Console.WriteLine(item.Key);
            PrintUnflatted(item.Value);
            PrintFlatted(item.Value);
            counter = 1;
        }
    }

    static void PrintUnflatted(Dictionary<string, string> value)
    {
        foreach (var item in value.Where(x => x.Value != "flatten").OrderBy(x => x.Key.Length))
        {
            Console.WriteLine($"{counter}. {item.Key} - {item.Value}");
            counter++;
        }
    }

    static void PrintFlatted(Dictionary<string, string> value)
    {
        foreach (var item in value.Where(x => x.Value == "flatten"))
        {
            Console.WriteLine($"{counter}. {item.Key}");
            counter++;
        }
    }
}