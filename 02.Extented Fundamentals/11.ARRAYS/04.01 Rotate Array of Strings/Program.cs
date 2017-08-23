using System;
class RotateArrayOfStrings_2
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        string[] splitInput = input.Split(' ');
        string[] rotatedArray = new string[splitInput.Length];

        InitializeRotatedArray(splitInput, rotatedArray);
        PrintRotatedArray(rotatedArray);
    }

    static string InitializeRotatedArray(string[] splitInput, string[] rotatedArray)
    {
        int length = splitInput.Length;
        rotatedArray[0] = splitInput[length - 1];

        for (int i = 0; i < length - 1; i++)
        {
            rotatedArray[i + 1] = splitInput[i];
        }
        return rotatedArray[length - 1];
    }

    static void PrintRotatedArray(string[] rotatedArray)
    {
        for (int i = 0; i < rotatedArray.Length; i++)
        {
            Console.Write($"{rotatedArray[i]} ");
        }
        Console.WriteLine();
    }
}