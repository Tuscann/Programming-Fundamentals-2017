using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        string comand = Console.ReadLine();

        int sum = 0;
        List<string> rotatedIntegers = new List<string>();

        for (int i = 0; i < input.Count; i++)
        {
            if (comand == "Max")
            {
                rotatedIntegers = GetMaxIntegersOnAllPositions(input);
                sum = GetSumOfIntegers(rotatedIntegers);
            }
            if (comand == "Min")
            {
                rotatedIntegers = GetMinIntegersOnAllPositions(input);
                sum = GetSumOfIntegers(rotatedIntegers);
            }
        }
        Console.WriteLine(string.Join(", ", rotatedIntegers));
        Console.WriteLine(sum);
    }
    static List<string> GetMinIntegersOnAllPositions(List<string> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            string minInteger = numbers[i];
            string rotatedNumbers = RotatadeNumbers(minInteger);

            if (int.Parse(numbers[i]) > int.Parse(rotatedNumbers))
            {
                numbers[i] = rotatedNumbers;
                i--;
            }

        }
        return numbers;
    }
    static List<string> GetMaxIntegersOnAllPositions(List<string> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            string minInteger = numbers[i];
            string rotatedNumbers = RotatadeNumbers(minInteger);

            if (int.Parse(numbers[i]) < int.Parse(rotatedNumbers))
            {
                numbers[i] = rotatedNumbers;
                i--;
            }
        }
        return numbers;
    }
    static string RotatadeNumbers(string numbers)
    {
        char[] charArray = numbers.ToCharArray();
        char first = charArray[0];
        string newNumber = string.Empty;

        for (int i = 1; i < charArray.Length; i++)
        {
            newNumber += charArray[i];
        }
        newNumber += first;

        return newNumber;
    }
    static int GetSumOfIntegers(List<string> numbers)
    {
        int sum = 0;

        foreach (var number in numbers)
        {
            sum += int.Parse(number);
        }
        return sum;
    }
}