using System;
using System.Collections.Generic;
using System.Linq;
public class DecodeRadioFrequencies
{
    public static void Main() // 100/100
    {
        decimal[] realNumberInput = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

        List<char> result = new List<char>();

        for (int i = 0; i < realNumberInput.Length; i++)
        {
            int integerNumber = GetInteger(realNumberInput[i]);
            int decimalNumber = GetDeciaml(realNumberInput[i]);

            char firsChar = (char)integerNumber;
            char secondChar = (char)decimalNumber;

            if (secondChar > 0)
            {
                result.Insert(i, secondChar);
            }
            if (firsChar > 0)
            {
                result.Insert(i, firsChar);
            }
        }

        Console.WriteLine(string.Join("", result));
    }

    static int GetDeciaml(decimal number)
    {
        int integerNumber = (int)number;

        string decimalNumberCheck = (number - integerNumber).ToString();
        char[] findCharAsciiCode = decimalNumberCheck.ToCharArray();

        string secondHalf = string.Empty;

        for (int i = 2; i < findCharAsciiCode.Length; i++)
        {
            secondHalf += findCharAsciiCode[i];
        }

        int decimalNumber = int.Parse(secondHalf);

        return decimalNumber;
    }

    static int GetInteger(decimal number)
    {
        int integerNumber = (int)number;

        return integerNumber;
    }
}