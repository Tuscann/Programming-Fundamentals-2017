using System;
class Program
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());

        decimal eps = 0.000001m;
        if (Math.Abs(a - b) >= eps)
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine("True");
        }
    }
}