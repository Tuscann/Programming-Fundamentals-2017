using System;
class Program
{
    static void signInteger(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("The number {0} is positive.", number);
        }
        else if (number < 0)
        {
            Console.WriteLine("The number {0} is negative.", number);
        }
        else if (number == 0)
        {
            Console.WriteLine("The number 0 is zero.");
        }
    }
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        signInteger(number);
    }
}
