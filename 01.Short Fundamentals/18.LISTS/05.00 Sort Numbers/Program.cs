using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<decimal> input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
        input.Sort();

        for (int i = 0; i < input.Count; i++)
        {
           
            if (i == input.Count - 1)
            {
                Console.Write("{0}", input[i]);
            }
            else
            {
                Console.Write("{0} <= ", input[i]);
            }
        }
    }
}