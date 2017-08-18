using System;

class P03_PrintingTriangle
{
    static void Main() // 100/100
    {
        int triangleWidth = int.Parse(Console.ReadLine());
        PrintTriangleOfNumbers(triangleWidth);
    }

    static void PrintTriangleOfNumbers(int triangleWidth)
    {
        for (int i = 1; i <= triangleWidth; i++)
        {
            Console.WriteLine(PrintTriangleLine(1, i));
        }
        for (int i = triangleWidth - 1; i >= 1; i--)
        {
            Console.WriteLine(PrintTriangleLine(1, i));
        }
    }

    static string PrintTriangleLine(int start, int end)
    {
        string result = string.Empty;
        for (int i = start; i <= end; i++)
        {
            result += i + " ";
        }
        return result;
    }
}