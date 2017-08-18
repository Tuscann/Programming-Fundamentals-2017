using System;
class P04_DrawAFilledSquare
{
    static void Main() // 100/100
    {
        int squareSize = int.Parse(Console.ReadLine());
        PrintFilledSquare(squareSize);
    }

    static void PrintFilledSquare(int squareSize)
    {
        PLinerintSquareTopBottom(squareSize);
        for (int i = 0; i < squareSize - 2; i++)
        {
            PrintSquareMiddleLine(squareSize);
        }
        PLinerintSquareTopBottom(squareSize);
    }

    static void PrintSquareMiddleLine(int squareSize)
    {

        Console.Write("-");
        for (int i = 0; i < squareSize - 1; i++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine("-");
    }

    static void PLinerintSquareTopBottom(int squareSize)
    {
        Console.WriteLine(new string('-', squareSize * 2));
    }
}