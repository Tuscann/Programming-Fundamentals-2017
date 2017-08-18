using System;
class Program
{
    static void Main() //100/100
    {
        try
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("It is a number.");
        }
        catch
        {
            Console.WriteLine("Invalid input!");
        }
    }
}