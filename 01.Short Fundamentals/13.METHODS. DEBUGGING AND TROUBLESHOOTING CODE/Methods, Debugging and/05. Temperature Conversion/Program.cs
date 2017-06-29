using System;
class Program
{
    static double convert(double number)
    {
        double sum = (number - 32) * 5 / 9;
        return sum;
    }

    static void Main()
    {
        var farennheit = double.Parse(Console.ReadLine());
        var celsius = convert(farennheit);
        Console.WriteLine("{0:f2}", celsius);
    }
}