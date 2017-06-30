using System;
class Program
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        //Console.WriteLine("{0:f12}",Math.PI*radius*radius);
        Console.WriteLine("{0:0.000000000000}", Math.PI * radius * radius);
    }
}