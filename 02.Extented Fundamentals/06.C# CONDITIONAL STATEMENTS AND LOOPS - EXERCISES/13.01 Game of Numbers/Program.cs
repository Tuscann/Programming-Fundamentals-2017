using System;
class P13_GameOfNumbers
{
    static void Main() //100/100
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        bool itsAKindOfMagic = false;
        string lastMagic = "";
        int combinationsCount = 0;
        for (int i = number1; i <= number2; i++)
        {
            for (int j = number1; j <= number2; j++)
            {
                combinationsCount++;
                if (i + j == magicNumber)
                {
                    lastMagic = $"Number found! {i} + {j} = {magicNumber}";
                    itsAKindOfMagic = true;
                }
            }
        }
        if (itsAKindOfMagic)
        {
            Console.WriteLine(lastMagic);
        }
        else
        {
            Console.WriteLine($"{combinationsCount} combinations - neither equals {magicNumber}");
        }
    }
}