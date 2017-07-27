using System;
using System.Linq;

class Program
{
    static void Main() // 66/100
    {
        char[] input = Console.ReadLine().ToCharArray();

        string output = String.Empty;
        int counter = 0;

        for (int i = 0; i < input.Length; i++)
        {
            bool digit = char.IsDigit(input[i]);
            
            if (!digit && counter != 0)
            {
                output += input[i];
                output += input[i];
                counter = 0;
                continue;
            }
            if (!digit)
            {
                output += input[i];
                continue;

            }
            counter++;

        }
        Console.WriteLine("{0}",string.Join("", output));
    }
}
