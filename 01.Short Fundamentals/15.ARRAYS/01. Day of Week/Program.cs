using System;
class Program
{
    static void Main() // 100/100
    {
        string[] days =
        {
                "Invalid Day!",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
        int number = int.Parse(Console.ReadLine());

        if (number >= 1 && number <= 7)
        {
            Console.WriteLine(days[number]);
        }
        else
        {
            Console.WriteLine(days[0]);
        }
    }
}