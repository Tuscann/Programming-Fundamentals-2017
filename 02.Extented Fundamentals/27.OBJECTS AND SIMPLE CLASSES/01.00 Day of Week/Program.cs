using System;
class Program
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        string[] dateNumbers = input.Split('-');
        int day = int.Parse(dateNumbers[0]);
        int month = int.Parse(dateNumbers[1]);
        int year = int.Parse(dateNumbers[2]);

        DateTime newDate = new DateTime(year, month, day);

        Console.WriteLine(newDate.DayOfWeek);
    }
}