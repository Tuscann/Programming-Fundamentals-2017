using System;
using System.Linq;
class Program
{
    static void Main()
    {

        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());
        bool isFound = true;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == n)
            {
                isFound = false;
            }
        }
        if (isFound)
        {
            Console.WriteLine("no");
        }
        else
        {
            Console.WriteLine("yes");
        }
    }
}