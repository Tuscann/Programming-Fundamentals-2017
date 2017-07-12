using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int num = 1; num <= number; num++)
        {
            int sumOfDigits = 0;
            int digits = num;
            while (digits > 0)
            {
                sumOfDigits += digits % 10;
                digits /= 10;
            }
            bool special = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
            Console.WriteLine("{0} -> {1}", num, special);
        }
    }
}