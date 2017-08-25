using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int camelback = int.Parse(Console.ReadLine());

        if (input.Count == camelback)
        {
            Console.WriteLine("already stable: {0}", string.Join(" ", input));
        }
        else
        {
            int lenght = (input.Count - camelback) / 2;
            Console.WriteLine("{0} rounds",lenght );
            Console.Write("remaining: ");
            for (int i = 0 + lenght; i < input.Count - lenght; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();
        }
    }
}