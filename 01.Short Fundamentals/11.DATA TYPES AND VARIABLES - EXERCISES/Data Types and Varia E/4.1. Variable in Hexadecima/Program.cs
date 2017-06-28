using System;
using System.Globalization;
class ConvertedToHexadecimalFormat
{
    static void Main()
    {
        string input = Console.ReadLine();

        int n;
        if (input.StartsWith("0x"))
        {
            n = Int32.Parse(input.Substring(2), NumberStyles.HexNumber);
        }
        else
        {
            n = Int32.Parse(input);
        }
        Console.WriteLine(n);
    }
}