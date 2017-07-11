using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rotate = int.Parse(Console.ReadLine());
        int[] sumResult = new int[arr.Length];

        for (int i = 0; i < rotate; i++)
        {
            int lastElement = arr[arr.Length - 1];

            for (int j = arr.Length - 1; j > 0; j--)
            {
                arr[j] = arr[j - 1];
            }
            arr[0] = lastElement;

            for (int w = 0; w < arr.Length; w++)
            {
                sumResult[w] += arr[w];
            }
        }
        Console.WriteLine(string.Join(" ", sumResult));
    }
}