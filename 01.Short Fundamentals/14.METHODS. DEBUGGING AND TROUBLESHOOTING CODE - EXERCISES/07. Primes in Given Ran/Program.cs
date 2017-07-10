using System;
class Program
{
    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endnumber = int.Parse(Console.ReadLine());
        string print = String.Empty;
        int counter = 0;


        for (int i = Math.Max(startNumber, 2); i <= endnumber; i++)
        {
            if (isPrime(i))
            {
                if (counter == 0)
                {
                    print += string.Concat("", i);
                    counter++;
                }
                else
                {
                    print += string.Concat(", ", i);
                }
            }
        }
        Console.WriteLine(print);
    }

    private static bool isPrime(int n)
    {
        int k = 2;
        while (k * k <= n)
        {
            if (n % k == 0)
            {
                return false;
            }
            k++;
        }
        return true;
    }
}