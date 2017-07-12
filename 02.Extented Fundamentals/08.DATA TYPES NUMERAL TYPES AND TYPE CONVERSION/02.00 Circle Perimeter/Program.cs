using System;
class Program
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine("{0:f12}", perimeter);
    }
}