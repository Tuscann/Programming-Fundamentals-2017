using System;
using System.Linq;
class Program
{
    static void Main() //100/100
    {
        double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double number = double.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > number)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}