using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] arrayOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int smallestDigit = int.MaxValue;

        foreach (int digit in arrayOfDigits)
        {
            if (digit < smallestDigit)
            {
                smallestDigit = digit;
            }
        }
        Console.WriteLine(smallestDigit);
    }
}