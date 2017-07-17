using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> listt = Console.ReadLine().Split().OrderBy(t => t).ToList();

        Console.WriteLine("{0}", string.Join(", ", listt));
    }
}