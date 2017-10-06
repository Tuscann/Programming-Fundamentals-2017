using System;

class Program // 100/100
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(number));
    }

    private static bool IsPrime(long number)
    {
        if (number == 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        int boundary = (int) Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}