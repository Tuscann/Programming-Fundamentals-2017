using System;
using System.Numerics;
public class Program
{
    public static void Main()  // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger result = 1;

        for (int i = n; i > 1; i--)
        {
            result *= i;
        }

        Console.WriteLine(result);
    }
}