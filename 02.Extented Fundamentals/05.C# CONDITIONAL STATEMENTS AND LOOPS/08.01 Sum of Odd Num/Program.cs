using System;
class P08_SumOfOddNumbers
{
    static void Main() // 100/100
    {
        int oddNumbersCount = int.Parse(Console.ReadLine());
        int sumOfOddNumbers = 0;

        for (int i = 1; i < oddNumbersCount * 2; i += 2)
        {
            sumOfOddNumbers += i;
            Console.WriteLine(i);
        }
        Console.WriteLine($"Sum: {sumOfOddNumbers}");
    }
}