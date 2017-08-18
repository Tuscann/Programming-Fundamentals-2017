using System;
class P08_MultiplyEvensOdds
{
    static void Main() // 100/100
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMultipleOfEvensAndOdds(number));
    }

    static int GetMultipleOfEvensAndOdds(int number)
    {
        number = Math.Abs(number);
        int evenDigitSum = GetSumOfOddOrEvenDigits(number, true);
        int oddDigitSum = GetSumOfOddOrEvenDigits(number, false);
        return evenDigitSum * oddDigitSum;
    }

    static int GetSumOfOddOrEvenDigits(int number, bool isEven)
    {
        int remainder = isEven ? 0 : 1;
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == remainder)
            {
                sum += digit;
            }
            number /= 10;
        }
        return sum;
    }
}