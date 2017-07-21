using System;
using System.Globalization;
class Program
{
    static void Main()  // 100/100
    {
        string date = Console.ReadLine();
        DateTime dateToPrint = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(dateToPrint.DayOfWeek);
    }
}