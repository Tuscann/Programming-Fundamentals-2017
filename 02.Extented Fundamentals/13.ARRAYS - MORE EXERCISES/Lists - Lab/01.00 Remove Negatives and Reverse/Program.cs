using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int counter = 0;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                Console.Write(array[i] + " ");
                counter++;
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("empty");
        }
    }
}