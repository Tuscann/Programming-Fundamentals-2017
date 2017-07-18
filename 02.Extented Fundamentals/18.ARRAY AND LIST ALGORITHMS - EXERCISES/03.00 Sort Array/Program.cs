using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();

        input.Sort();

        Console.WriteLine(string.Join(" ", input));
    }
}