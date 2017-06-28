using System;
class Program
{
    static void Main()
    {
        string first = Console.ReadLine();
        string secound = Console.ReadLine();
        string third = Console.ReadLine();

        string print = first + secound + third;

        char[] charArray = print.ToCharArray();

        Array.Reverse(charArray);

        Console.WriteLine(charArray);
    }
}