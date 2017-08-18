using System;
class P12_NumberChecker
{
    static void Main() // 100/100
    {
        try
        {
            double.Parse(Console.ReadLine());
            Console.WriteLine("It is a number.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
        }
    }
}