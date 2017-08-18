using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main() // 100/100
    {
        int[] arr = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        string line = Console.ReadLine();

        while (line != "end")
        {
            string[] tokens = line.Split();
            string command = tokens[0];

            switch (command)
            {
                case "exchange":
                    int index = int.Parse(tokens[1]);

                    arr = ExchangeArreyElements(arr, index);
                    break;
                case "max":
                case "min":
                    string maxOrMin = command;
                    string evenOrOdd = tokens[1];

                    FindMaxOrMinEvenOrOddElement(arr, maxOrMin, evenOrOdd);
                    break;
                case "first":
                case "last":
                    string firstOrLast = command;
                    int count = int.Parse(tokens[1]);
                    evenOrOdd = tokens[2];

                    FindFirstOrLastEvenOrOddElements(arr, firstOrLast, count, evenOrOdd);
                    break;
            }

            line = Console.ReadLine();
        }

        Console.WriteLine("[{0}]", string.Join(", ", arr));
    }

    private static void FindFirstOrLastEvenOrOddElements(int[] arr, string firstOrLast, int count, string evenOrOdd)
    {
        if (count > arr.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        int evenOrOdParity = evenOrOdd == "even" ? 0 : 1;
        IEnumerable<int> evenOrOddElements = arr.Where(a => a % 2 == evenOrOdParity);

        int[] foundElements;
        if (firstOrLast == "first")
        {
            foundElements = evenOrOddElements
                .Take(count)
                .ToArray();
        }
        else
        {
            foundElements = evenOrOddElements
                .Reverse()
                .Take(count)
                .Reverse()
                .ToArray();
        }
        Console.WriteLine("[{0}]", string.Join(", ", foundElements));
    }

    private static void FindMaxOrMinEvenOrOddElement(int[] arr, string maxOrMin, string evenOrOdd)
    {
        int evenOrOddElementsParity = evenOrOdd == "even" ? 0 : 1;
        int[] evenOrOddElements = arr.Where(a => a % 2 == evenOrOddElementsParity).ToArray();

        if (!evenOrOddElements.Any())
        {
            Console.WriteLine("No matches");
            return;
        }

        int maxOrMinElement = 0;
        if (maxOrMin == "max")
        {
            maxOrMinElement = evenOrOddElements.Max();
        }
        else
        {
            maxOrMinElement = evenOrOddElements.Min();
        }

        int maxOrMinElementIndex = Array.LastIndexOf(arr, maxOrMinElement);
        Console.WriteLine(maxOrMinElementIndex);
    }

    private static int[] ExchangeArreyElements(int[] arr, int index)
    {
        bool isValidIndex = index >= 0 && index < arr.Length;
        if (!isValidIndex)
        {
            Console.WriteLine("Invalid index");
            return arr;
        }

        IEnumerable<int> leftPart = arr.Take(index + 1);
        IEnumerable<int> rightPart = arr.Skip(index + 1);

        int[] combinedArray = rightPart.Concat(leftPart).ToArray();
        return combinedArray;
    }
}