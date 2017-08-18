using System;
using System.Globalization;
class P09_HolidaysBetweenTwoDates
{
    static void Main() // 100/100
    {
        string dateFormatString = "d.M.yyyy";
        DateTime startDate = DateTime.ParseExact(
            Console.ReadLine(),
            dateFormatString,
            CultureInfo.InvariantCulture
        );
        DateTime endDate = DateTime.ParseExact(
            Console.ReadLine(),
            dateFormatString,
            CultureInfo.InvariantCulture
        );
        int holidaysCount = GetWeekendsCount(startDate, endDate);
        Console.WriteLine(holidaysCount);
    }

    static int GetWeekendsCount(DateTime startDate, DateTime endDate)
    {
        startDate = startDate.AddDays(
            (int)startDate.DayOfWeek >= 1 ?
                6 - (int)startDate.DayOfWeek :
                0
        );
        int weekendsCount = 0;
        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday)
            {
                weekendsCount++;
            }
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                weekendsCount++;
                date = date.AddDays(5);
            }
        }
        return weekendsCount;
    }
}
