using System;
class GivenElementInArray_2
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        int givenElement = int.Parse(Console.ReadLine());

        string[] splitInput = input.Split(' ');
        int[] array = new int[splitInput.Length];

        InitializeArray(splitInput, array);
        int occurrencesOfGivenElement = CountOccurrencesOfGivenElement(array, givenElement);
        Console.WriteLine(occurrencesOfGivenElement);
    }

    static int InitializeArray(string[] splitInput, int[] array)
    {
        int length = splitInput.Length;
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(splitInput[i]);
        }
        return array[length - 1];
    }

    static int CountOccurrencesOfGivenElement(int[] array, int givenElement)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == givenElement)
            {
                counter++;
            }
        }
        return counter;
    }
}