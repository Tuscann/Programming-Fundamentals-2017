using System;
class Program
{
    static void Main() // 100/100
    {
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:f12}",Math.PI*radius*radius);
    }
}