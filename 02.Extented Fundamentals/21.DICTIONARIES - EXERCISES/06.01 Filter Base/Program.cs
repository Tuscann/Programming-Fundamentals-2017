using System;
using System.Collections.Generic;
using System.Linq;

public class FilterBase
{
    public static void Main()
    {
        var inputData = Console.ReadLine();

        var ageDictionary = new Dictionary<string, int>();
        var salaryDictionary = new Dictionary<string, double>();
        var positionDictionary = new Dictionary<string, string>();

        while (inputData != "filter base")
        {
            var input = inputData.Split(" ->".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            var name = input[0];
            var valueData = input[1];

            var age = 0;
            var salary = 0.0;
            var position = string.Empty;
            bool isPosition = true;

            if (int.TryParse(valueData, out age))
            {
                age = int.Parse(valueData);
                ageDictionary[name] = age;
                isPosition = false;
            }
            else if (double.TryParse(valueData, out salary))
            {
                salary = double.Parse(valueData);
                salaryDictionary[name] = salary;
                isPosition = false;
            }
            else if (isPosition)
            {
                position = valueData;
                positionDictionary[name] = position;
            }
            inputData = Console.ReadLine();
        }
        inputData = Console.ReadLine();

        switch (inputData)
        {
            case "Position":
                OutputResult(positionDictionary);
                break;
            case "Age":
                OutputResult(ageDictionary);
                break;
            case "Salary":
                OutputResult(salaryDictionary);
                break;
        }
    }

    static void OutputResult(Dictionary<string, double> dictionary)
    {
        foreach (var kvp in dictionary)
        {
            var name = kvp.Key;
            var valueOutput = kvp.Value;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Salary: {valueOutput:f2}");
            Console.WriteLine(new String('=', 20));
        }
    }

    static void OutputResult(Dictionary<string, int> dictionary)
    {
        foreach (var kvp in dictionary)
        {
            var name = kvp.Key;
            var valueOutput = kvp.Value;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {valueOutput}");
            Console.WriteLine(new String('=', 20));
        }
    }

    static void OutputResult(Dictionary<string, string> dictionary)
    {
        foreach (var kvp in dictionary)
        {
            var name = kvp.Key;
            var valueOutput = kvp.Value;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Position: {valueOutput}");
            Console.WriteLine(new String('=', 20));
        }
    }
}