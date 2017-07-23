using System;
using System.Numerics;
class Program
{
    static void Main()  // 100/100
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());

        Console.WriteLine("{0}", first + second);
    }
}