using System;
class MasterNumbers
{
    static void Main()  // 100/100
    {
        int input = int.Parse(Console.ReadLine());
        for (int i = 1; i <= input; i++)
        {
            if (isSymetric(i))
            {
                if (holdEvenDigitAndDivisible(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    private static bool holdEvenDigitAndDivisible(int input)
    {
        int digit = 0;
        int sum = 0;
        bool divisible = false;
        bool evenDigit = false;
        int len = input.ToString().Length;
        for (int i = 0; i < len; i++)
        {
            digit = input % 10;
            if (digit % 2 == 0)
            {
                evenDigit = true;
            }
            input /= 10;
            sum += digit;
        }
        if (sum % 7 == 0) divisible = true;
        if (divisible && evenDigit) return true;
        return false;
    }

    private static bool isSymetric(int input)
    {
        string str = input.ToString();
        int length = input.ToString().Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}