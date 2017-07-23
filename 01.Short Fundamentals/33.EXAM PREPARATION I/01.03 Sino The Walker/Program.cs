using System;
using System.Globalization;
using System.Numerics;
class Program
{
    static void Main()  // 80/100
    {
        DateTime leaveTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
        BigInteger steps = BigInteger.Parse(Console.ReadLine());
        BigInteger seconds = BigInteger.Parse(Console.ReadLine());

        BigInteger stepsBySeconds = steps * seconds;

        DateTime arrivalTime = leaveTime.AddSeconds((double)stepsBySeconds);

        Console.WriteLine("Time Arrival: {0}", arrivalTime.ToString("HH:mm:ss"));

    }
}
