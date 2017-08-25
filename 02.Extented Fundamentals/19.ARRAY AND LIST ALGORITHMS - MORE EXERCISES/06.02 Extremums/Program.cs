using System;
using System.Collections.Generic;
using System.Linq;
public class Extremums
{
    public static void Main()  // 30/100
    {
        List<int> numbers = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

        string command = Console.ReadLine();

        int sum = 0;
        List<int> rotatedIntegers = new List<int>();

        switch (command)
        {
            case "Max":
                rotatedIntegers = GetMaxIntegersOnAllPositions(numbers);
                sum = GetSumOfIntegers(rotatedIntegers);
                break;
            case "Min":
                rotatedIntegers = GetMinIntegersOnAllPositions(numbers);
                sum = GetSumOfIntegers(rotatedIntegers);
                break;
        }
        Console.WriteLine(string.Join(", ", rotatedIntegers));
        Console.WriteLine(sum);
    }

    static List<int> GetMaxIntegersOnAllPositions(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            string minInteger = numbers[i].ToString();
            int rotatedNumbers = RotatadeNumbers(minInteger);

            if (numbers[i] < rotatedNumbers)
            {
                numbers[i] = rotatedNumbers;
                i--;
            }
        }
        return numbers;
    }

    static List<int> GetMinIntegersOnAllPositions(List<int> numbers)
    {

        for (int i = 0; i < numbers.Count; i++)
        {
            string minInteger = numbers[i].ToString();
            int rotatedNumbers = RotatadeNumbers(minInteger);

            if (numbers[i] > rotatedNumbers)
            {
                numbers[i] = rotatedNumbers;
                i--;
            }
        }
        return numbers;
    }

    static int RotatadeNumbers(string numbers)
    {
        char[] charArray = numbers.ToCharArray();
        char first = charArray[0];
        string newNumber = string.Empty;

        for (int i = 1; i < charArray.Length; i++)
        {
            newNumber += charArray[i];
        }
        newNumber += first;

        int result = int.Parse(newNumber);

        return result;
    }

    static int GetSumOfIntegers(List<int> numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }
}