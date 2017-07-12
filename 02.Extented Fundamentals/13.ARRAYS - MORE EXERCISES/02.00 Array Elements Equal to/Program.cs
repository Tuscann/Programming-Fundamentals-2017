using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == i)
            {
                Console.Write(i + " ");
            }
        }
    }
}
