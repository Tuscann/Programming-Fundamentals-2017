using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<string> inpit = Console.ReadLine().Split(' ').ToList();
        List<string> print = new List<string>();

        for (int i = 1; i < inpit.Count; i++)
        {
            if (i % 2 != 0)
            {
                print.Add(inpit[i]);
            }
        }
        Console.WriteLine(string.Join("", print));
    }
}