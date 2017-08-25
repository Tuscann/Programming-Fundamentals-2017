using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int specialNumber = int.Parse(Console.ReadLine());

        bool isNumberFound = isFound(inputArray, specialNumber);

        if (isNumberFound)
        {
            Console.WriteLine("Yes");
           
        }
        if (isNumberFound == false)
        {
            Console.WriteLine("No");
        }
        int repats = LinearSearch(inputArray, specialNumber);
        Console.WriteLine($"Linear search made {repats} iterations");

        Array.Sort(inputArray);

        int binres = BinarySearch(inputArray, specialNumber);
        Console.WriteLine($"Binary search made {binres} iterations");
    }

    static int LinearSearch(int[] arr, int number)
    {
        int iterations = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            iterations++;
            if (arr[i] == number)
            {
                break;
            }
            
        }
        return iterations;
    }
    static bool isFound(int[] arr, int number)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                return true;
            }
        }
        return false;
    }

    static int BinarySearch(int[] binaryArray, int specialNumber)
    {
        int min = 0;
        int max = binaryArray.Length - 1;
        int iterations = 0;
        do
        {
            iterations++;
            int mid = (min + max) / 2;
            if (binaryArray[mid] < specialNumber)
                min = mid + 1;
            else
                max = mid - 1;
            if (binaryArray[mid] == specialNumber)
                return iterations;
        }
        while (min <= max);
        return iterations;
    }
}
