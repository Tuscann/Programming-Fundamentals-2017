using System;
class Program
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        int total = hours * 60 + minutes + 30;

        int curentHour = total / 60;
        int curenntMinutes = total % 60;

        if (total / 60 == 24)
        {
            curentHour = 0;
        }
        Console.WriteLine("{0}:{1}", curentHour, curenntMinutes.ToString().PadLeft(2, '0'));
    }
}
