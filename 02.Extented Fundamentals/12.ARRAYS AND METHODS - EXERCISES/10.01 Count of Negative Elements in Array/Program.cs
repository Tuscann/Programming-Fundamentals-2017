using System;
class CountNegativeElements_2
{
    static void Main() // 100/100
    {
        uint n = uint.Parse(Console.ReadLine());
        int[] array = new int[n];

        InitializeArray(n, array);
        int negativeElementsCounter = CountNegativeElements(array);
        Console.WriteLine(negativeElementsCounter);
    }

    static int InitializeArray(uint n, int[] array)
    {
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array[n - 1];
    }

    static int CountNegativeElements(int[] array)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                counter++;
            }
        }
        return counter;
    }
}
