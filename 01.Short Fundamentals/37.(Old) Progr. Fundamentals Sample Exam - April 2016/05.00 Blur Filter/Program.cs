using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int blurAmount = int.Parse(Console.ReadLine());
        int[] infoMatrix = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int MatrixRows = infoMatrix[0];
        int MatrixCols = infoMatrix[1];
        decimal[,] mainMatrix = new decimal[MatrixRows, MatrixCols];

        // FILL IN MATRIX
        for (int rows = 0; rows < MatrixRows; rows++)
        {
            int[] readLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int cols = 0; cols < MatrixCols; cols++)
            {
                mainMatrix[rows, cols] = readLine[cols];
            }
        }

        // BLUR INFO
        int[] infoBlur = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int blurRow = infoBlur[0];
        int blurCol = infoBlur[1];

        int blurStartRows = blurRow - 1;
        int blurEndRows = blurStartRows + 3;
        if (blurStartRows < 0) blurStartRows = 0;
        if (blurEndRows > MatrixRows) blurEndRows = MatrixRows;

        int blurStartCols = blurCol - 1;
        int blurEndCols = blurStartCols + 3;
        if (blurStartCols < 0) blurStartCols = 0;
        if (blurEndCols > MatrixCols) blurEndCols = MatrixCols;

        //ADDING BLUR

        for (int rows = blurStartRows; rows < blurEndRows; rows++)
        {
            for (int cols = blurStartCols; cols < blurEndCols; cols++)
            {
                mainMatrix[rows, cols] = mainMatrix[rows, cols] + blurAmount;
            }
        }
        for (int rows = 0; rows < MatrixRows; rows++)
        {
            for (int cols = 0; cols < MatrixCols; cols++)
            {
                Console.Write(mainMatrix[rows, cols] + " ");
            }
            Console.WriteLine();
        }
    }
}