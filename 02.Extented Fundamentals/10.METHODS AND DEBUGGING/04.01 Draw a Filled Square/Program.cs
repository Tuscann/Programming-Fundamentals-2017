using System;
class DrawAFilledSquare_2
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        PrintSquare(n);
    }

    static void PrintEndRows(int n)
    {
        for (int col = 1; col <= 2 * n; col++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }

    static void PrintMiddleRows(int n)
    {
        for (int row = 1; row <= n - 2; row++)
        {
            Console.Write("-");
            for (int col = 1; col <= n - 1; col++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }

    static void PrintSquare(int n)
    {
        PrintEndRows(n);
        PrintMiddleRows(n);
        PrintEndRows(n);
    }
}