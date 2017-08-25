using System;
using System.Collections.Generic;
using System.Linq;

public class CottageScraper
{
    public static void Main() // 100/100
    {
        List<string> typeAndLenght = Console.ReadLine()
            .Split(" ->".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        Dictionary<string, List<int>> woodType = new Dictionary<string, List<int>>();
        int woodCout = 0;

        // add all woods and lenght we have in dictionery
        while (typeAndLenght[0] != "chop")
        {
            string woodName = typeAndLenght[0];
            int woodHeight = int.Parse(typeAndLenght[1]);

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

        
        string typeOfTree = Console.ReadLine();                // name of wood we need and minnimum lenght
        int minLenght = int.Parse(Console.ReadLine());

        double pricePerMeter = 0d;

        foreach (KeyValuePair<string, List<int>> wood in woodType)
        {
            string name = wood.Key;
            List<int> value = wood.Value;

            for (int i = 0; i < value.Count; i++)
            {
                pricePerMeter += value[i];
            }
        }

        double allLogs = pricePerMeter;

        pricePerMeter = Math.Round(pricePerMeter / woodCout, 2);

        // finde the price of ussed logs
        int usedLogs = woodType
            .Where(u => u.Key == typeOfTree)
            .SelectMany(u => u.Value)
            .Where(u => u >= minLenght)
            .Sum();

        double allUnusedLogs = allLogs - usedLogs;

        double usedLogPrice = Math.Round((usedLogs * pricePerMeter), 2);
        
        // find the price of unsedlogs

        double priceForUnUsuedLogs = Math.Round((allUnusedLogs * pricePerMeter * 0.25), 2);
        
        //find the subtotal price

        double subTotal = usedLogPrice + priceForUnUsuedLogs;

        Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
        Console.WriteLine($"Used logs price: ${usedLogPrice:f2}");
        Console.WriteLine($"Unused logs price: ${priceForUnUsuedLogs:f2}");
        Console.WriteLine($"CottageScraper subtotal: ${subTotal:f2}");
    }
}