using System;
class IncrementVariable
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        int overflow = 0;

        for (byte i = 1; i < n; i++)
        {
            if (i == 0)
            {
                overflow++;
                n -= 256;
            }
        }
        Console.WriteLine(n);

        if (overflow > 0)
        {
            Console.WriteLine("Overflowed {0} times", overflow);
        }
    }
}