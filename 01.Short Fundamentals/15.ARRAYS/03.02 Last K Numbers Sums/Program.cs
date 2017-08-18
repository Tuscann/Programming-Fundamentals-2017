using System;
class Program
{
    static void Main() // 100/100
    {
        long n = long.Parse(Console.ReadLine());
        long k = long.Parse(Console.ReadLine());

        long[] numbers = new long[n];
        numbers[0] = 1;

        for (long current = 1; current < numbers.Length; current++)
        {
            numbers[current] = SumOfpreviousKElements(numbers, current, k);
        }

        for (long current = 0; current < numbers.Length; current++)
        {
            Console.WriteLine(numbers[current]);
        }
    }
    static long SumOfpreviousKElements(long[] numbers, long index, long k)
    {
        long sum = 0;

        for (long i = Math.Max(index - k, 0); i < index; i++)
        {
            sum = sum + numbers[i];
        }
        return sum;
    }
}