using System;
using System.Linq;
class TheMatrix
{
    static void Main() // 100/100
    {
        //Matrix Dimensions
        long[] matrixDimensions = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long rows = matrixDimensions[0];
        long cols = matrixDimensions[1];

        //Creating and Filling our new matrix
        long[,] matrix = new long[rows, cols];

        for (long i = 0; i < rows; i++)
        {
            long[] row = Console.ReadLine().Split().Select(long.Parse).ToArray();

            for (long j = 0; j < cols; j++)
            {
                matrix[i, j] = row[j];
            }
        }
        //Special Point
        long[] blurCoordinates = Console.ReadLine().Split().Select(long.Parse).ToArray();

        long point = matrix[blurCoordinates[0], blurCoordinates[1]];
        long sum = 0;

        long startRow = blurCoordinates[0] - 1 >= 0 ? blurCoordinates[0] - 1 : 0;
        long startCol = blurCoordinates[1] - 1 >= 0 ? blurCoordinates[1] - 1 : 0;
        long endRow = blurCoordinates[0] + 1 < rows ? blurCoordinates[0] + 1 : rows - 1;
        long endCol = blurCoordinates[1] + 1 < cols ? blurCoordinates[1] + 1 : cols - 1;

        for (long i = startRow; i <= endRow; i++)
        {
            for (long j = startCol; j <= endCol; j++)
            {
                sum = sum + matrix[i, j];
                matrix[i, j] = matrix[i, j] * point;
                matrix[blurCoordinates[0], blurCoordinates[1]] /= point;

            }
        }
        matrix[blurCoordinates[0], blurCoordinates[1]] = point * sum;

        PrintMatrix(matrix);
    }

    static void PrintMatrix(long[,] matrix)
    {
        for (long i = 0; i < matrix.GetLength(0); i++)
        {
            for (long j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}