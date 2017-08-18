using System;
public class Program
{
    public static void Main() // 100/100
    {
        TimeSpan time = TimeSpan.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine()) % 86400;
        int seconds = int.Parse(Console.ReadLine()) % 86400;

        long sumStep = step * seconds;
        TimeSpan asdf = TimeSpan.FromSeconds(sumStep);


        TimeSpan timeSum = time + asdf;

        Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}", timeSum);
    }
}