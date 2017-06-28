using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        if (n > long.MaxValue || n < long.MinValue)
        {
            Console.WriteLine(n + " can't fit in any type");
        }
        else
        {
            Console.WriteLine(n + " can fit in:");
            if (n >= sbyte.MinValue && n <= sbyte.MaxValue)
            {
                Console.WriteLine("* sbyte");
            }
            if (n >= byte.MinValue && n <= byte.MaxValue)
            {
                Console.WriteLine("* byte");
            }
            if (n >= short.MinValue && n <= short.MaxValue)
            {
                Console.WriteLine("* short");
            }
            if (n >= ushort.MinValue && n <= ushort.MaxValue)
            {
                Console.WriteLine("* ushort");
            }
            if (n >= int.MinValue && n <= int.MaxValue)
            {
                Console.WriteLine("* int");
            }
            if (n >= uint.MinValue && n <= uint.MaxValue)
            {
                Console.WriteLine("* uint");
            }
            if (n >= long.MinValue && n <= long.MaxValue)
            {
                Console.WriteLine("* long");
            }
        }
    }
}
