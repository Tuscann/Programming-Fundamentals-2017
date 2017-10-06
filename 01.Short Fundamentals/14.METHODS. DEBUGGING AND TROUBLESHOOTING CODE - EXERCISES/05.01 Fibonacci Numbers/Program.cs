using System;
using System.Collections.Generic;
class FibonacciNumbers
{
    static void Main() // 100/100
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(input));
    }

    private static int Fib(int input)
    {
        List<int> fibonacciList = new List<int>();
        fibonacciList.Add(1);
        fibonacciList.Add(1);
        for (int i = 2; i <= input; i++)
        {
            fibonacciList.Add(fibonacciList[i - 1] + fibonacciList[i - 2]);
        }
        return fibonacciList[fibonacciList.Count - 1];
    }
}