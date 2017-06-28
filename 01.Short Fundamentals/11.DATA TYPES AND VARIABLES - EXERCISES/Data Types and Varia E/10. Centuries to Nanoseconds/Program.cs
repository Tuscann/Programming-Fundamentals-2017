using System;
class CenturiesToNanosec
{
    static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        decimal minutes = hours * 60M;
        decimal seconds = minutes * 60;
        decimal milliseconds = seconds * 1000;
        decimal microseconds = milliseconds * 1000;
        decimal nanoseconds = microseconds * 1000;

        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
    }
}