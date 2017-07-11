using System;
class Program
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool[] primes = new Boolean[n + 1];

        primes[0] = primes[1] = false;

        for (int i = 2; i <= n; i++)
        {
            primes[i] = true;
        }

        for (int i = 2; i <= n; i++)
        {
            if (primes[i])
            {
                for (int j = i + i; j < primes.Length; j += i)
                {
                    primes[j] = false;
                }
            }
        }
        for (int i = 0; i < primes.Length; i++)
        {
            if (primes[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}

