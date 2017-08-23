using System;
class MultiplyEvensByOdds
{
    static void Main() // 100/100
    {
        int number = int.Parse(Console.ReadLine());
        int multiplyEvensByOdds = MultiplyEvensAndOdds(Math.Abs(number));
        Console.WriteLine(multiplyEvensByOdds);
    }

    static int SumOddDigits(int n)
    {
        int sumOdd = 0;

        while (n != 0)
        {
            int currentDigit = n % 10;

            if (currentDigit % 2 == 1)
            {
                sumOdd += currentDigit;
            }
            n -= currentDigit;
            n /= 10;
        }
        return sumOdd;
    }

    static int SumEvenDigits(int n)
    {
        int sumEven = 0;

        while (n != 0)
        {
            int currentDigit = n % 10;

            if (currentDigit % 2 == 0)
            {
                sumEven += currentDigit;
            }
            n -= currentDigit;
            n /= 10;
        }
        return sumEven;
    }

    static int MultiplyEvensAndOdds(int n)
    {
        int sumOfOddDigits = SumOddDigits(n);
        int sumOfEvenDigits = SumEvenDigits(n);
        return sumOfEvenDigits * sumOfOddDigits;
    }
}