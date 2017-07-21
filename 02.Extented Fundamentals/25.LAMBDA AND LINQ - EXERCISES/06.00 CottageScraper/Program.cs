using System;
using System.Collections.Generic;
using System.Linq;

public class CottageScraper
{
    public static void Main()
    {
        var typeAndLenght = Console.ReadLine()
            .Split(" ->".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        var woodType = new Dictionary<string, List<int>>();
        var woodCout = 0;

        // add all woods and lenght we have in dictionery
        while (typeAndLenght[0] != "chop")
        {
            var woodName = typeAndLenght[0];
            var woodHeight = int.Parse(typeAndLenght[1]);

            if (!woodType.ContainsKey(woodName))
            {
                woodType[woodName] = new List<int>();
            }
            woodType[woodName].Add(woodHeight);


            typeAndLenght = Console.ReadLine()
                .Split(" ->".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            woodCout++;
        }

        
        var typeOfTree = Console.ReadLine();                // name of wood we need and minnimum lenght
        var minLenght = int.Parse(Console.ReadLine());

        var pricePerMeter = 0d;

        foreach (var wood in woodType)
        {
            var name = wood.Key;
            var value = wood.Value;

            for (int i = 0; i < value.Count; i++)
            {
                pricePerMeter += value[i];
            }
        }

        var allLogs = pricePerMeter;

        pricePerMeter = Math.Round(pricePerMeter / woodCout, 2);

        // finde the price of ussed logs
        var usedLogs = woodType
            .Where(u => u.Key == typeOfTree)
            .SelectMany(u => u.Value)
            .Where(u => u >= minLenght)
            .Sum();

        var allUnusedLogs = allLogs - usedLogs;

        var usedLogPrice = Math.Round((usedLogs * pricePerMeter), 2);
        
        // find the price of unsedlogs

        var priceForUnUsuedLogs = Math.Round((allUnusedLogs * pricePerMeter * 0.25), 2);


        //find the subtotal price

        var subTotal = usedLogPrice + priceForUnUsuedLogs;

        Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
        Console.WriteLine($"Used logs price: ${usedLogPrice:f2}");
        Console.WriteLine($"Unused logs price: ${priceForUnUsuedLogs:f2}");
        Console.WriteLine($"CottageScraper subtotal: ${subTotal:f2}");
    }
}