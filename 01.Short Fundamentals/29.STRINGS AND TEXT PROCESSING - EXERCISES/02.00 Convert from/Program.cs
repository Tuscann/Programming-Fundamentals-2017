using System;
using System.Linq;
using System.Numerics;
public class ConvertFromBaseNToBase10   // 100/100
{
    public static void Main()
    {
        BigInteger[] input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
        BigInteger baseN = input[0];
        BigInteger number = input[1];
        BigInteger pow = 0;
        BigInteger result = 0;

        while (number > 0)
        {
            BigInteger digit = number % 10;
            BigInteger baseNRaisedToPower = 1;

            if (pow == 0)
            {
                baseNRaisedToPower = 1;
            }
            else
            {
                for (int i = 0; i < pow; i++)
                {
                    baseNRaisedToPower *= baseN;
                }
            }

            result += digit * baseNRaisedToPower;
            pow++;
            number = number / 10;
        }
        Console.WriteLine(result);
    }
}
