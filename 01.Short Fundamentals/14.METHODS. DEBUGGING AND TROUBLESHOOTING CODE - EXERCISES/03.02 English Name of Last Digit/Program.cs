using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        long num = long.Parse(Console.ReadLine());
        byte digit = (byte)Math.Abs(num % 10);
        Dictionary<int, string> dictionaryDigits = new Dictionary<int, string>
        {
            [1] = "one",
            [2] = "two",
            [3] = "three",
            [4] = "four",
            [5] = "five",
            [6] = "six",
            [7] = "seven",
            [8] = "eight",
            [9] = "nine",
            [0] = "zero"
        };
        Console.WriteLine(dictionaryDigits[digit]);
    }
}