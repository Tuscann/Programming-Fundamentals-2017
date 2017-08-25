using System;
using System.Linq;
class SortArrayBubbleSort
{
    static void Main() // 100/100
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        DoBubbleSort(numbers);
        Console.WriteLine(String.Join(" ", numbers));
    }

    static int[] DoBubbleSort(int[] numbers)
    {
        bool isSorted = false;

        while (!isSorted)
        {
            bool isSwapped = false;
            for (int index = 0; index < numbers.Length - 1; index++)
            {
                if (numbers[index] > numbers[index + 1])
                {
                    Swap(ref numbers[index], ref numbers[index + 1]);
                    isSwapped = true;
                }
            }

            if (isSwapped == false)
            {
                break;
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