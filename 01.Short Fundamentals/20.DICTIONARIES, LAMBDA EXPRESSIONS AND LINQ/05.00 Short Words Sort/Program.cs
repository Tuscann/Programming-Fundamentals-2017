using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> input = Console.ReadLine()
            .Split(",.:;()[]\"'\\/!? ".ToArray(), StringSplitOptions.RemoveEmptyEntries)
            .Where(str => str.Length < 5)
            .OrderBy(str => str)
            .Select(str => str.ToLower())
            .Distinct()
            .ToList();

        Console.WriteLine("{0}", string.Join(", ", input));
    }
}