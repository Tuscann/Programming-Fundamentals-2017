using System;
class Program
{
    static void Main()
    {
        try
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("It is a number.");
        }
        catch
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

