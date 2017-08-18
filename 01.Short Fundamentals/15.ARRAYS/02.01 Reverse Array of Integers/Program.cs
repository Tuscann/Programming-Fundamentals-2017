using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        List<int> list = new List<int>();

        for (int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }
        list.Reverse();

        foreach (var number in list)
        {
            Console.WriteLine(number);
        }
    }
}