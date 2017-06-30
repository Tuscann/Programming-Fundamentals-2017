using System;
class Program
{
    static int sumEvenNumber(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int ostatak = number % 10;
            number /= 10;
            if (ostatak % 2 == 0)
            {
                sum += ostatak;
            }
        }
        return sum;
    }
    static int sumOddNumber(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int ostatak = number % 10;
            number /= 10;
            if (ostatak % 2 == 1)
            {
               sum += ostatak;
            }
        }
        return sum;
    }

    static void Main()
    {
        int number = Math.Abs(int.Parse(Console.ReadLine()));
        int even = sumEvenNumber(number);
        int odd = sumOddNumber(number);
        Console.WriteLine(even * odd);
    }
}