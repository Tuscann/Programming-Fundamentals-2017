using System;
class NthDigit_2
{
    static void Main()  // 100/100
    {
        long number = long.Parse(Console.ReadLine());
        int index = int.Parse(Console.ReadLine());

        int nthDigit = FindNthDigit(number, index);
        Console.WriteLine(nthDigit);
    }

    static int FindNthDigit(long number, int index)
    {
        int currentIteration = 1;
        int nthDigit = 0;

        while (number > 0)
        {
            long digit = number % 10;
            number /= 10;

            if (currentIteration == index)
            {
                nthDigit = (int)digit;
                break;
            }
            currentIteration++;
        }
        return nthDigit;
    }
}