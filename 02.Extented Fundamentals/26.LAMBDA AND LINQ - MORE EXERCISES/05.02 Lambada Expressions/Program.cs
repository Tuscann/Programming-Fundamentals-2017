using System;
using System.Collections.Generic;
using System.Linq;
public class LambadaExpressions
{
    public static void Main()
    {
        var collection = new Dictionary<string, string>();
        var enteredLine = Console.ReadLine().Split(" =>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
        while (enteredLine[0] != "lambada")
        {
            if (enteredLine[0] != "dance")
            {
                collection[enteredLine[0]] = enteredLine[1];
            }
            if (enteredLine[0] == "dance")
            {
                collection = collection.ToDictionary(x => x.Key, x => $"{x.Key}.{x.Value}");
            }

            enteredLine = Console.ReadLine().Split(" =>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        foreach (var item in collection)
        {
            Console.WriteLine($"{item.Key} => {item.Value}");
        }
    }
}