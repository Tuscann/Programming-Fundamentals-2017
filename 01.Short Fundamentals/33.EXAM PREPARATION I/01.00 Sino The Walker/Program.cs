using System;

public class Program
{
    public static void Main()
    {
        TimeSpan time = TimeSpan.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine()) % 86400;
        int seconds = int.Parse(Console.ReadLine()) % 86400;
        
        TimeSpan timeSum = time + TimeSpan.FromSeconds(step * seconds);

        Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}", timeSum);
    }
}