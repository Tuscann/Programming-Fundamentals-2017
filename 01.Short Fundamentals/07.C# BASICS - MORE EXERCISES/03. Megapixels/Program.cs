using System;
class Program
{
    static void Main()
    {
        decimal width = decimal.Parse(Console.ReadLine());
        decimal height = decimal.Parse(Console.ReadLine());

        decimal number = 1000000;

        decimal sum = width * height / number;

        Console.WriteLine("{0}x{1} => {2}MP", width, height, Math.Round(sum,1));
     }
}
