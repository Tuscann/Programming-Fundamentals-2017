using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 1; i <= array.Length - 1; i++)
        {
            if (array[i] % 2 != 0 && i % 2 != 0)
            {
                Console.WriteLine("Index {0} -> {1}", i, array[i]);
            }
        }
    }
}