using System;
using System.Globalization;
public class SinoTheWalker
{
    public static void Main() // 100/100
    {
        DateTime time = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
        int numberOfSteps = int.Parse(Console.ReadLine()) % 86400;
        int timeInSecondsForStep = int.Parse(Console.ReadLine()) % 86400;

        long totalSeconds = numberOfSteps * timeInSecondsForStep;
        DateTime totalTime = time.AddSeconds(totalSeconds);
        string result = totalTime.TimeOfDay.ToString();

        Console.WriteLine($"Time Arrival: {result}");
    }
}