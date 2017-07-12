using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rotaions = int.Parse(Console.ReadLine());
        int[] sumArray = new int[array.Length];

        for (int i = 0; i < rotaions; i++)
        {
            Rotate(array);
            for (int j = 0; j < array.Length; j++)
            {
                sumArray[j] += array[j];
            }
        }
        Console.WriteLine(string.Join(" ", sumArray));
    }
    private static void Rotate(int[] array)
    {
        var lastElelment = array[array.Length - 1];
        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = lastElelment;
    }
}