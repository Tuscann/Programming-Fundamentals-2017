using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();

        int isCapital = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length == 1 && char.IsUpper(char.Parse(input[i])))
            {
                isCapital++;
            }
        }
        Console.WriteLine(isCapital);
    }
}