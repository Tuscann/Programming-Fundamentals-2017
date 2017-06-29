using System;
class Program
{
    static double raisedPower(double number, int power)
    {
        double sum = Math.Pow(number, power);
        return sum;
    }
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        double powerNumber = raisedPower(number, power);
        Console.WriteLine(powerNumber);
    }
}