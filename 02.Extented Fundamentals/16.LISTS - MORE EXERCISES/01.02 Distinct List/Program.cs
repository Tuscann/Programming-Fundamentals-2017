using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> inputIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        for (int rowCycle = 0; rowCycle < inputIntegers.Count; rowCycle++)
        {
            for (int digitCycle = 1 + rowCycle; digitCycle < inputIntegers.Count; digitCycle++)
            {
                if (inputIntegers[rowCycle] == inputIntegers[digitCycle])
                {
                    inputIntegers.RemoveAt(digitCycle);
                    digitCycle--;
                }
            }
        }
        Console.WriteLine(string.Join(" ", inputIntegers));
    }
}
