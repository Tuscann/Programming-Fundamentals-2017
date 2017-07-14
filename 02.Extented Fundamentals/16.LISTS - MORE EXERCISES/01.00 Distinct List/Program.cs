using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        IEnumerable<int> uniqueItems = input.Distinct();
        Console.WriteLine(string.Join(" ", uniqueItems));
    }
}