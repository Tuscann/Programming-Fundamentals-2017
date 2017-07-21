using System;
using System.Collections.Generic;
using System.Linq;
public class ArrayData
{
    public static void Main()   // 100/100
    {
        List<long> givenArray = Console.ReadLine().Split(' ').Select(x => Convert.ToInt64(x)).ToList();
        double average = givenArray.Average();
        List<long> currentArray = givenArray.Where(x => x >= average).ToList();

        string command = Console.ReadLine();
        if (command == "Min")
        {
            Console.WriteLine(currentArray.Min());
        }
        else if (command == "Max")
        {
            Console.WriteLine(currentArray.Max());
        }
        else
        {
            Console.WriteLine(string.Join(" ", currentArray.OrderBy(x => x)));
        }
    }
}