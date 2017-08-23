using System;
class SmallestElementInArray
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        string[] splitInput = input.Split(' ');
        int[] array = new int[splitInput.Length];

        for (int i = 0; i < splitInput.Length; i++)
        {
            array[i] = int.Parse(splitInput[i]);
        }
        int minValue = array[0];
        
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }
        Console.WriteLine(minValue);
    }
}