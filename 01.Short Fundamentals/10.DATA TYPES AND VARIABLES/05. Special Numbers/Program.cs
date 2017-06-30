using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int num = 1; num <= number; num++)
        {
            int SumOfDigits = 0;
            int digits = num;
            while (digits > 0)
            {
                SumOfDigits = SumOfDigits + digits % 10;
                digits = digits / 10;
            }
            bool special = SumOfDigits == 5 || SumOfDigits == 7 || SumOfDigits == 11;
            Console.WriteLine("{0} -> {1}", num, special);
        }
    }
}