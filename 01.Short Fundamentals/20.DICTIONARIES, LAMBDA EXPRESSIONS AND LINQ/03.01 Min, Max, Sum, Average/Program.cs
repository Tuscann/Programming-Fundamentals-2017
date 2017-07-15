
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

       LinkedList<int> input = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            int curentNUmber = int.Parse(Console.ReadLine());
            input.AddLast(curentNUmber);
        }
        Console.WriteLine("Sum = {0}", input.Sum());
        Console.WriteLine("Min = {0}", input.Min());
        Console.WriteLine("Max = {0}", input.Max());
        Console.WriteLine("Average = {0}", input.Average());
    }
}