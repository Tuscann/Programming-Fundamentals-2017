using System;
class Program
{
    static void Main()
    {
        string[] first = Console.ReadLine().Split(' ');
        string[] second = Console.ReadLine().Split(' ');

        int smallerArrayLenght = Math.Min(first.Length, second.Length);
        int leftCounter = CheckArrays(smallerArrayLenght, first, second);

        Array.Reverse(first);
        Array.Reverse(second);

        int rightCounter = CheckArrays(smallerArrayLenght, first, second);
        Console.WriteLine(leftCounter > rightCounter ? leftCounter : rightCounter);
    }

    private static int CheckArrays(int smallerArrayLenght, string[] first, string[] second)
    {
        int Counter = 0;
        for (int i = 0; i < smallerArrayLenght; i++)
        {
            if (first[i] == second[i])
            {
                Counter++;
            }
        }
        return Counter;
    }
}