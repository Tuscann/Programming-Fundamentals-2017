using System;
class Program
{
    static void Main() // 100/100
    {
        long n = long.Parse(Console.ReadLine());
        long k = long.Parse(Console.ReadLine());

        long[] arr = new long[n];
        arr[0] = 1;

        for (long current = 1; current < arr.Length; current++)
        {
            long start = Math.Max(0, current - k);
            long end = current - 1;
            long sum = 0;

            for (long previous = start; previous <= end; previous++)
            {
                sum += arr[previous];
            }
            arr[current] = sum;
        }
        for (long i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i] + " ");
        }
        Console.WriteLine();
    }
}