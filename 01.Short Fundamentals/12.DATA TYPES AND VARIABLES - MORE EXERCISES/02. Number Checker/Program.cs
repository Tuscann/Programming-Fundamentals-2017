using System;
class Program
{
    static void Main()
    {
        string number = Console.ReadLine();

        if (number.Contains(".") == true)
        {
            Console.WriteLine("floating-point");
        }
        else
        {
            Console.WriteLine("integer");
        }
    }
}