using System;
using System.Globalization;
class Program
{
    static void Main()  // 80/100
    {
        string dateAsText = Console.ReadLine();
        DateTime date = DateTime.ParseExact(
            dateAsText, "d-M-yyyy",
            CultureInfo.InvariantCulture);
        Console.WriteLine(date.DayOfWeek);

    }
}