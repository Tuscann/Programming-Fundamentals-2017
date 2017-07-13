using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        var list = Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        var lowerCase = new List<string>();
        var mixedCase = new List<string>();
        var upperCase = new List<string>();
        int lower = 0, upper = 0;
        foreach (var item in list)
        {
            foreach (var letters in item)
            {
                if (letters >= 'a' && letters <= 'z')
                {
                    lower++;
                }
                else if (letters >= 'A' && letters <= 'Z')
                {
                    upper++;
                }
                else if (letters >= ' ' && letters <= '@')
                {
                    lower++;
                    upper++;
                }
            }
            if (lower > 0 && upper == 0)
            {
                lowerCase.Add(item);
            }
            else if (lower == 0 && upper > 0)
            {
                upperCase.Add(item);

            }
            else if (lower > 0 && upper > 0)
            {
                mixedCase.Add(item);
            }
            upper = 0;
            lower = 0;
        }
        Console.Write("Lower-case: ");
        Console.WriteLine(string.Join(", ", lowerCase));
        Console.Write("Mixed-case: ");
        Console.WriteLine(string.Join(", ", mixedCase));
        Console.Write("Upper-case: ");
        Console.WriteLine(string.Join(", ", upperCase));
    }
}