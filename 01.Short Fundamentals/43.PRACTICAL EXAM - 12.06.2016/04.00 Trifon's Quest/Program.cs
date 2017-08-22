using System;
using System.Linq;
class Program
{
    static void Main()
    {
        long healthTrifon = long.Parse(Console.ReadLine());

        long[] dimensionsMat = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        long rows = dimensionsMat[0];
        long cols = dimensionsMat[1];

        char[][] matrixLetters = new char[rows][];

        BuildTheMap(rows, matrixLetters);

        long col = 0;
        long row = 0;
        long turns = 0;
        long endOfQuesting = rows * cols;

        while (turns < endOfQuesting)
        {
            if (matrixLetters[row][col] == 'F')
            {
                healthTrifon -= turns / 2;
            }
            else if (matrixLetters[row][col] == 'H')
            {
                healthTrifon += turns / 3;
            }
            else if (matrixLetters[row][col] == 'T')
            {
                turns += 2;
                endOfQuesting += 2;
            }
            if (healthTrifon <= 0)
            {
                Console.WriteLine($"Died at: [{row}, {col}]");
                break;
            }
            if (col % 2 == 1)
            {
                row--;
            }
            if (row == rows - 1 || (row == -1 && col % 2 == 1))
            {
                col++;
            }
            if (col % 2 == 0)
            {
                row++;
            }
            turns++;
        }
        if (healthTrifon > 0)
        {
            Console.WriteLine("Quest completed!");
            Console.WriteLine($"Health: {healthTrifon}");
            Console.WriteLine($"Turns: {turns}");
        }
    }
    private static void BuildTheMap(long rows, char[][] matrixLetters)
    {
        string[] arrRowLetters = new string[rows];

        for (long row = 0; row < rows; row++)
        {
            arrRowLetters[row] = Console.ReadLine();
        }

        for (long row = 0; row < rows; row++)
        {
            matrixLetters[row] = arrRowLetters[row].ToCharArray();
        }
    }
}