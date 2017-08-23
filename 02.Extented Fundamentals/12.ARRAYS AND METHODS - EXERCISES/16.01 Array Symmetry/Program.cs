using System;
class ArraySymmetry
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        string[] splitInput = input.Split(' ');

        int length = splitInput.Length;
        int middleOfArray = length % 2 == 0 ? length / 2 - 1 : length / 2;
        bool isSymmetric = true;

        if (length % 2 == 0)
        {
            if (splitInput[middleOfArray] != splitInput[middleOfArray + 1])
            {
                isSymmetric = false;
            }
        }
        int i = 0;
        while (i < middleOfArray && isSymmetric)
        {
            if (splitInput[i] != splitInput[length - 1 - i])
            {
                isSymmetric = false;
            }
            i++;
        }

        string result = String.Empty;
        if (isSymmetric)
        {
            result = "Yes";
        }
        else
        {
            result = "No";
        }
        Console.WriteLine(result);
    }
}