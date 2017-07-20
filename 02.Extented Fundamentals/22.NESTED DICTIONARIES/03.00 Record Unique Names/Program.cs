using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> list = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string curent = Console.ReadLine();
            list.Add(curent);
        }
        Console.WriteLine("{0}", string.Join("\n", list.Distinct()));
    }
}