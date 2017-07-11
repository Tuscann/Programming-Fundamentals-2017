using System;
class Program
{
    static string IntegerToBase(long number, int tobase)
    {
        string output = String.Empty;
        output += number / tobase;
        output += number % tobase;

        return output;
    }
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int toBase = int.Parse(Console.ReadLine());

        Console.WriteLine(IntegerToBase(number, toBase));
    }
}