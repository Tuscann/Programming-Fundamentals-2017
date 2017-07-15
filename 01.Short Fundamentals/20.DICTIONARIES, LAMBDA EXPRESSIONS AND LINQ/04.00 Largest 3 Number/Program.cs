using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split().Select(a => int.Parse(a)).ToList();
        
        Console.WriteLine(string.Join(", ",input.OrderByDescending(x => x).Take(3)));
    }
}