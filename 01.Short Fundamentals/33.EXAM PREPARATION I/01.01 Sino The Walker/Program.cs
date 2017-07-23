using System;
class Program
{
    static void Main()
    {
        DateTime starttime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", null);

        double steps = double.Parse(Console.ReadLine()) % 86400;              //86400 секунди = 1 ден
        double secsonsperstep = double.Parse(Console.ReadLine()) % 86400;     //86400 секунди = 1 ден
        double res = steps * secsonsperstep;

        DateTime Arrival = starttime.AddSeconds(res);
        Console.WriteLine("Time Arrival: {0}", Arrival.ToString("HH:mm:ss"));
    }
}