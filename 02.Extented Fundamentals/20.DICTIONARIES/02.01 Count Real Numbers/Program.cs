using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<double> numbers = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        SortedDictionary<double, int> output = new SortedDictionary<double, int>();

        foreach (double number in numbers)
        {
            if (!output.ContainsKey(number))
            {
                output[number] = 0;
            }
            output[number]++;
        }

        foreach (KeyValuePair<double, int> kvp in output)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}