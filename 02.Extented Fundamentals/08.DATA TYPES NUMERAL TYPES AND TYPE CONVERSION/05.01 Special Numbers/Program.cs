using System;

public class SpecialNumbers
{
    public static void Main() // 100/100
    {
        long toThisNumberCounting = long.Parse(Console.ReadLine());

        long temp = 0;

        long sum = 0;

        for (long counter = 1; counter <= toThisNumberCounting; counter++)
        {
            temp = counter;

            while (temp != 0)
            {
                sum += temp % 10;

                temp /= 10;
            }
            if (sum == 5 || sum == 7 || sum == 11)
            {
                Console.WriteLine($"{counter} -> True");
            }
            else
            {
                Console.WriteLine($"{counter} -> False");
            }
            sum = 0;
        }
    }
}