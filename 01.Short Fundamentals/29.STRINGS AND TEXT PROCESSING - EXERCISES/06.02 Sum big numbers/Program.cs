using System;
using System.Text;
class Program
{
    static void Main()  // 100/100
    {
        string firstNum = Console.ReadLine().TrimStart('0');
        string secNum = Console.ReadLine().TrimStart('0');

        int pad = Math.Max(firstNum.Length, secNum.Length);

        if (firstNum.Length != secNum.Length)
        {
            firstNum = firstNum.PadLeft(pad, '0');
            secNum = secNum.PadLeft(pad, '0');
        }

        int inMind = 0;
        int remainder = 0;
        StringBuilder result = new StringBuilder();

        for (int i = firstNum.Length - 1; i >= 0; i--)
        {
            int sum = int.Parse(firstNum[i].ToString()) + int.Parse(secNum[i].ToString()) + inMind;
            inMind = sum / 10;
            remainder = sum % 10;
            result.Insert(0, remainder.ToString());
            if (i == 0 && inMind != 0)
            {
                result.Insert(0, inMind.ToString());
            }
        }
        Console.WriteLine(result);
    }
}
