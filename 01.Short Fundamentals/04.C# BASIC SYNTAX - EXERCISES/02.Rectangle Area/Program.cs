using System;
class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:f2}",width*height);
    }
}