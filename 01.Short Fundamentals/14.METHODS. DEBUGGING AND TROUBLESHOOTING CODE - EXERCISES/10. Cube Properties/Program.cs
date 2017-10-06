using System;
class Program
{
    static void Main() // 100/100
    {
        double a = double.Parse(Console.ReadLine());
        string shape = Console.ReadLine();

        Console.WriteLine("{0:f2}", Calclulate(a, shape));
    }
    static double Calclulate(double a, string shape)
    {
        double sum = 0;
        switch (shape)
        {
            case "volume":
                sum = Math.Pow(a, 3); break;
            case "space":
                sum = Math.Sqrt(3 * a * a); break;
            case "area":
                sum = 6 * a * a; break;
            case "face":
                sum = Math.Sqrt(2 * a * a); break;
        }
        return sum;
    }
}