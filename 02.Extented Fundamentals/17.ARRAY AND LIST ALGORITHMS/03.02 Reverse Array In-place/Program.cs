using System;
using System.Linq;
class ReverseArray
{
    static void Main() //100/100
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int start = 0, end = array.Length - 1; start < end; start++, end--)
        {
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;
        }
        Console.WriteLine(String.Join(" ", array));
    }
}