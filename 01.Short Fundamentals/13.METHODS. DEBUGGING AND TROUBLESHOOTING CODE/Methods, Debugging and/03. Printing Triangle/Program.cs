using System;
class Program
{
    static void printTriangle(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine();
        }
        for (int i = number - 1; i > 0; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        printTriangle(number);
    }
}