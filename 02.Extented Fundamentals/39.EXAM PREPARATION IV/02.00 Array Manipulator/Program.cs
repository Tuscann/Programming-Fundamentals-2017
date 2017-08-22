using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        while (true)
        {
            string inputLine = Console.ReadLine();

            if (inputLine == "end")
            {
                break;
            }

            string[] commandLine = inputLine.Split();

            string command = commandLine[0];
            switch (command)
            {
                case "exchange":
                    int index = int.Parse(commandLine[1]);

                    if (index < 0 || index >= arr.Length)
                    {
                        Console.WriteLine("Invalid index");
                        break;
                    }

                    int[] leftPart = arr.Take(index + 1).ToArray();
                    int[] rightPart = arr.Skip(index + 1).ToArray();
                    arr = rightPart.Concat(leftPart).ToArray();

                    break;

                case "max":
                case "min":
                    string maxOrMin = command;
                    string evenOrOdd = commandLine[1];

                    GetIndexOfElement(arr, maxOrMin, evenOrOdd);
                    break;

                case "first":
                case "last":
                    string firstOrLast = command;
                    int count = int.Parse(commandLine[1]);
                    evenOrOdd = commandLine[2];

                    ReturnCountElements(arr, firstOrLast, count, evenOrOdd);
                    break;
            }
        }

        Console.WriteLine("[{0}]", string.Join(", ", arr));
    }

    private static void ReturnCountElements(int[] arr, string firstOrLast, int count, string evenOrOdd)
    {
        if (count < 0 || count > arr.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        int result = evenOrOdd == "even" ? 0 : 1;
        int[] evenOrOddElements = arr.Where(s => s % 2 == result).ToArray();
        int[] lastOrFirstArr = firstOrLast == "first" ? evenOrOddElements.Take(count).ToArray()
            : evenOrOddElements.Reverse().Take(count).Reverse().ToArray();

        Console.WriteLine("[{0}]", string.Join(", ", lastOrFirstArr));
    }

    private static void GetIndexOfElement(int[] arr, string maxOrMin, string evenOrOdd)
    {
        int result = evenOrOdd == "even" ? 0 : 1;
        int[] evenOrOddElements = arr.Where(s => s % 2 == result).ToArray();

        if (evenOrOddElements.Length == 0)
        {
            Console.WriteLine("No matches");
            return;
        }

        int maxOrMinElement = maxOrMin == "max" ? evenOrOddElements.Max() : evenOrOddElements.Min();
        int lastIndexOfElement = Array.LastIndexOf(arr, maxOrMinElement);

        Console.WriteLine(lastIndexOfElement);
    }
}