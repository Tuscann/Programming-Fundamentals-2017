using System;
using System.Collections.Generic;
public class FilterBase
{
    public static void Main() // 100/100
    {
        string inputData = Console.ReadLine();

        Dictionary<string, int> ageDictionary = new Dictionary<string, int>();
        Dictionary<string, double> salaryDictionary = new Dictionary<string, double>();
        Dictionary<string, string> positionDictionary = new Dictionary<string, string>();

        while (inputData != "filter base")
        {
            string[] input = inputData.Split(" ->".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            string name = input[0];
            string valueData = input[1];

            int age = 0;
            double salary = 0.0;
            string position = string.Empty;
            

            if (int.TryParse(valueData, out age))
            {
                age = int.Parse(valueData);
                ageDictionary[name] = age;
                
            }
            else if (double.TryParse(valueData, out salary))
            {
                salary = double.Parse(valueData);
                salaryDictionary[name] = salary;
            }
            else 
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
        foreach (KeyValuePair<string, double> kvp in dictionary)
        {
            string name = kvp.Key;
            double valueOutput = kvp.Value;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Salary: {valueOutput:f2}");
            Console.WriteLine(new String('=', 20));
        }
    }

    static void OutputResult(Dictionary<string, int> dictionary)
    {
        foreach (KeyValuePair<string, int> kvp in dictionary)
        {
            string name = kvp.Key;
            int valueOutput = kvp.Value;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {valueOutput}");
            Console.WriteLine(new String('=', 20));
        }
    }

    static void OutputResult(Dictionary<string, string> dictionary)
    {
        foreach (KeyValuePair<string, string> kvp in dictionary)
        {
            string name = kvp.Key;
            string valueOutput = kvp.Value;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Position: {valueOutput}");
            Console.WriteLine(new String('=', 20));
        }
    }
}