using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()   // 100/100
    {
        string[] input = Console.ReadLine().Split(' ');

        List<char> first = input[0].ToCharArray().Distinct().ToList();
        List<char> second = input[1].ToCharArray().Distinct().ToList();

        bool exchengable = first.Count == second.Count;

        Console.WriteLine(exchengable.ToString().ToLower());
    }
}