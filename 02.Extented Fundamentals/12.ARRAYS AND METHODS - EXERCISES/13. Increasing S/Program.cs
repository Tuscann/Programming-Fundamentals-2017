using System;
using System.Linq;

class Program
{
    static void Main() // 100/100
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool no = false;

        for (int i = 1; i <= array.Length - 1; i++)
        {
            if (array[i - 1] < array[i])
            {
                no = true;
            }
            else
            {
                no = false;
                break;
            }
        }
        if (no)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}