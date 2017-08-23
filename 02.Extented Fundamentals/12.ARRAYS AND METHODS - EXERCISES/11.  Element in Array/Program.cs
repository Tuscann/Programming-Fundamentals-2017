using System;
using System.Linq;

class Program
{
    static void Main() // 100/100
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int number = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}