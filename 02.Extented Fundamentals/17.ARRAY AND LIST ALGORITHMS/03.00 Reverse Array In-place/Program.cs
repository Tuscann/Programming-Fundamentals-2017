using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] input = Console.ReadLine().Split().Select(a => int.Parse(a)).ToArray();

        for (int i = 0; i < input.Length / 2; i++)
        {
            int temp = input[i];
            input[i] = input[input.Length - 1 - i];
            input[input.Length - 1 - i] = temp;
        }
        Console.WriteLine("{0}", string.Join(" ", input));
    }
}