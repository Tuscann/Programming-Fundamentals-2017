using System;
using System.Globalization;
class Program
{
    static void Main()  // 100/100
    {
        DateTime timeOfLeaving = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
        int steps = int.Parse(Console.ReadLine());
        int secondsPerStep = int.Parse(Console.ReadLine());
        ulong secondsToAdd = (ulong)steps * (ulong)secondsPerStep;
        long initialSeconds = timeOfLeaving.Hour * 60 * 60 + timeOfLeaving.Minute * 60 + timeOfLeaving.Second;
        ulong totalSeconds = (ulong)initialSeconds + secondsToAdd;
        ulong seconds = totalSeconds % 60;
        ulong totalMinutes = totalSeconds / 60;
        ulong minutes = totalMinutes % 60;
        ulong totalHours = totalMinutes / 60;
        ulong hours = totalHours % 24;

        Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");
    }
}