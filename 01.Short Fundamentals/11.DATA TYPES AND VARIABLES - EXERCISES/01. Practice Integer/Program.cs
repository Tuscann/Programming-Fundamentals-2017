using System;
class Program
{
    static void Main()
    {
        sbyte a = sbyte.Parse(Console.ReadLine());
        byte b = byte.Parse(Console.ReadLine());
        short c = short.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        decimal e = decimal.Parse(Console.ReadLine());
        decimal i = decimal.Parse(Console.ReadLine());
        long k = long.Parse(Console.ReadLine());

        Console.WriteLine(a + "\n" + b + "\n" + c + "\n" + d + "\n" + e + "\n" + i + "\n" + k + "\n");
    }
}