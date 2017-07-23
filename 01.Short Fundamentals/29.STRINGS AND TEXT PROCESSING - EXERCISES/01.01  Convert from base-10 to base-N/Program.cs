using System;
using System.Linq;
using System.Numerics;
public class ConvertFromBase10ToBaseN
{
    public static void Main()
    {
        BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
        BigInteger baseN = numbers[0];
        BigInteger number = numbers[1];
        string result = string.Empty;

        while (number > 0)
        {
            BigInteger lastDigit = number % baseN;
            number = number / baseN;
            result += lastDigit.ToString();
        }
        Console.WriteLine(string.Join("", result.Reverse()));
    }
}