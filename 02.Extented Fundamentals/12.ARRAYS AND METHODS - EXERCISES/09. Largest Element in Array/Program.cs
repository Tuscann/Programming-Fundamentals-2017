using System;
using System.Linq;
class Program
{
    static void Main() //100/100
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            int curremt = int.Parse(Console.ReadLine());
            array[i] = curremt;
        }
        Console.WriteLine(array.Max());
    }
}