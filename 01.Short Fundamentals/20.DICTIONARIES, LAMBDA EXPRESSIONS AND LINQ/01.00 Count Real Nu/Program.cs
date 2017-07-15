using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        SortedDictionary<double, int> dict = new SortedDictionary<double, int>();

        List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        foreach (double number in input)
        {
            if (dict.ContainsKey(number))
            {
                dict[number]++;
            }
            else
            {
                dict.Add(number, 1);
            }
        }
        foreach (KeyValuePair<double, int> doubleNumber in dict)
        {
            Console.WriteLine("{0} -> {1}", doubleNumber.Key, doubleNumber.Value);
        }
    }
}