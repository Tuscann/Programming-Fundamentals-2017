using System;
using System.Linq;
class ArrayInsertionSort
{
    static void Main() // 100 /100
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        DoInsertionSort(numbers);
        Console.WriteLine(String.Join(" ", numbers));
    }

    static int[] DoInsertionSort(int[] numbers)
    {
        for (int firstIndex = 1; firstIndex < numbers.Length; firstIndex++)
        {
            for (int secondIndex = firstIndex; secondIndex > 0; secondIndex--)
            {
                if (numbers[secondIndex - 1] > numbers[secondIndex])
                {
                    Swap(ref numbers[secondIndex - 1], ref numbers[secondIndex]);
                }
                else
                {
                    break;
                }
            }
        }
        return numbers;
    }
    static void Swap(ref int first, ref int second)
    {
        int temp = first;
        first = second;
        second = temp;
    }
}