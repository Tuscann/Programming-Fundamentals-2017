using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int min = int.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        Console.WriteLine(min);
    }
}