using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> lineOfDigits = Console.ReadLine()
            .Split()
            .Where(x => x.Length == 2)
            .Reverse()
            .ToList();

        for (int i = 0; i < lineOfDigits.Count; i++)
        {
            string reversedNum = new string(lineOfDigits[i].ToCharArray().Reverse().ToArray());
            lineOfDigits[i] = reversedNum;
        }

        foreach (string hex in lineOfDigits)
        {
            int value = Convert.ToInt32(hex, 16);
            Console.Write((char)value);
        }
    }
}
