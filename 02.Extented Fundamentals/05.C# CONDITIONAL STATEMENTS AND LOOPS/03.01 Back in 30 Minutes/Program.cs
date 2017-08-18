using System;
class P03_BackIn30Minutes
{
    static void Main() // 100/100
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 30;
        while (minutes >= 60)
        {
            minutes -= 60;
            hours++;
        }

        while (hours >= 24)
        {
            hours -= 24;
        }

        Console.WriteLine($"{hours}:{minutes:D2}");
    }
}
