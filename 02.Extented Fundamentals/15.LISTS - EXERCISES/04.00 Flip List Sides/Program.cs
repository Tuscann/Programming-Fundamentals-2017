using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var output = new LinkedList<int>();

        for (int i = input.Count - 2; i >= 1; i--)
        {
            output.AddLast(input[i]);
        }
        output.AddFirst(input.First());
        output.AddLast(input.Last());

        Console.WriteLine(string.Join(" ", output));
    }
}