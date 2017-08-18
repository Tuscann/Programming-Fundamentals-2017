using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long[] solution = new long[n];
        solution[0] = 1;

        for (int i = 1; i < n; i++)
        {
            long sum = 0;
            for (int j = i - k; j <= i - 1; j++)
            {
                if (j >= 0)
                {
                    sum += solution[j];
                }
                solution[i] = sum;
            }
        }
        Console.WriteLine(string.Join(" ", solution));
    }
}