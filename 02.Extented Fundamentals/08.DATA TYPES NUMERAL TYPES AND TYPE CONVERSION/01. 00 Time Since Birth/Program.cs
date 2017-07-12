using System;
class Program
{
    static void Main()
    {
        int years = int.Parse(Console.ReadLine());
        int days = years * 365;
        int hours = years * 365 * 24;
        int minutes = years * 365 * 24 * 60;

        Console.WriteLine("{0} years = {1} days = {2} hours = {3} minutes.", years, days, hours, minutes);
    }
}
