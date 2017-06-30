using System;
class Program
{
    static void Main()
    {
        double mile = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:f2}", mile * 1.60934);
    }
}
