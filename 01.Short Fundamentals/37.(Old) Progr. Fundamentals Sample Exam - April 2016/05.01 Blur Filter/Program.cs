using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int blurAmount = int.Parse(Console.ReadLine());
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

        double[,] matrix = new double[size[0], size[1]];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string[] nums = Console.ReadLine().Split();

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = double.Parse(nums[j]);
            }
        }
        int[] targetCordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

        matrix[targetCordinates[0], targetCordinates[1]] += blurAmount;

        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        if (targetCordinates[0] - 1 >= 0) { matrix[targetCordinates[0] - 1, targetCordinates[1]] += blurAmount; }
        if (targetCordinates[0] + 1 < row) { matrix[targetCordinates[0] + 1, targetCordinates[1]] += blurAmount; }
        if (targetCordinates[1] + 1 < col) { matrix[targetCordinates[0], targetCordinates[1] + 1] += blurAmount; }
        if (targetCordinates[1] - 1 >= 0) { matrix[targetCordinates[0], targetCordinates[1] - 1] += blurAmount; }

        if (targetCordinates[0] - 1 >= 0 && targetCordinates[1] - 1 >= 0)
        { matrix[targetCordinates[0] - 1, targetCordinates[1] - 1] += blurAmount; }

        if (targetCordinates[0] + 1 < row && targetCordinates[1] + 1 < col)
        { matrix[targetCordinates[0] + 1, targetCordinates[1] + 1] += blurAmount; }

        if (targetCordinates[0] - 1 >= 0 && targetCordinates[1] + 1 < col)
        { matrix[targetCordinates[0] - 1, targetCordinates[1] + 1] += blurAmount; }

        if (targetCordinates[0] + 1 < row && targetCordinates[1] - 1 >= 0)
        { matrix[targetCordinates[0] + 1, targetCordinates[1] - 1] += blurAmount; }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}