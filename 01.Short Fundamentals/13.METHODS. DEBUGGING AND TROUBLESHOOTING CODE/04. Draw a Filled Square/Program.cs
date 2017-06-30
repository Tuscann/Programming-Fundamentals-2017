using System;
class Program
{
    static void printTopRow(int number)
    {
        Console.WriteLine("{0}", new string('-', 2 * number));
    }
    static void printMiddle(int number)
    {
        Console.Write("-");
        for (int i = 1; i < number; i++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine("-");
    }
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        printTopRow(number);
        for (int i = 1; i <= number-2; i++)
        {
            printMiddle(number);
        }
        printTopRow(number);
    }
}