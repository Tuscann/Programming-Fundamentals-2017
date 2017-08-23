using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        int[] newArray = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int m = int.Parse(Console.ReadLine());
            newArray[i] = m;
            sum += newArray[i];
        }
        Console.WriteLine(sum);
    }
}