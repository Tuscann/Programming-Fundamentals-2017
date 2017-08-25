using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static bool isFound;
    public static void Main() // 100 /100
    {
        List<int> list = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        int numberToFind = int.Parse(Console.ReadLine());

        int linearSearchCounter = 0;
        int binarySearchCounter = 0;
        isFound = false;

        linearSearchCounter = DoLinearSearchAndCountIterations(list, numberToFind, linearSearchCounter);
        list.Sort();
        binarySearchCounter = DoBinarySearchAndCountIterations(list, numberToFind, binarySearchCounter);

        if (isFound)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

        Console.WriteLine($"Linear search made {linearSearchCounter} iterations");
        Console.WriteLine($"Binary search made {binarySearchCounter} iterations");


    }

    private static int DoBinarySearchAndCountIterations(List<int> list, int numberToFind, int binarySearchCounter)
    {
        int left = 0;
        int right = list.Count - 1;

        isFound = false;
        while (!isFound)
        {
            if (right < left)
            {
                isFound = false;
                return binarySearchCounter;
            }

            binarySearchCounter++;
            int midPoint = left + (right - left) / 2;

            if (list[midPoint] < numberToFind)
            {
                left = midPoint + 1;
            }
            else if (list[midPoint] > numberToFind)
            {
                right = midPoint - 1;
            }
            else if (list[midPoint] == numberToFind)
            {
                isFound = true;
            }
        }

        return binarySearchCounter;
    }

    private static int DoLinearSearchAndCountIterations(List<int> list, int numberToFind, int linearSearchCounter)
    {
        for (int i = 0; i < list.Count; i++)
        {
            linearSearchCounter++;
            if (list[i] == numberToFind)
            {
                isFound = true;
                break;
            }
        }
        return linearSearchCounter;
    }
}