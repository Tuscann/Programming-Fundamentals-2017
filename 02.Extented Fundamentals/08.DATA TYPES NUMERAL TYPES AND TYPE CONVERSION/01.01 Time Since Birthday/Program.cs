using System;
class Program
{
    static void Main() // 100/100
    {
        Console.Write("Centuries = ");
        double centuries = double.Parse(Console.ReadLine());
        double years = centuries * 100;
        double days = (int)(years * 365.2422);
        double hours = days * 24;
        double minutes = 60 * hours;

        Console.WriteLine("{4} centuries\n{0:f0} years\n{1:f0} days\n{2:f0} hours\n{3:f0} minutes", years, days, hours, minutes, centuries);
    }
}