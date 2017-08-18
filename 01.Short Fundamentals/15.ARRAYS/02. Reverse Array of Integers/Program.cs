using System;
class Program
{
    static void Main() // 100/100
    {
        int numbers = int.Parse(Console.ReadLine());

        int[] arr = new int[numbers];

        for (int i = numbers - 1; i >= 0; i--)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(string.Join(" ", arr));
    }
}