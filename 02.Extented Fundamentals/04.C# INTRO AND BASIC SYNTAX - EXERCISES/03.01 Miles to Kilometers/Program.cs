using System;
public class P03_MilesToKilometers
{
    public static void Main() // 100/100
    {

        double distanceInMiles = double.Parse(Console.ReadLine());
        const double kilometersPerMile = 1.60934;

        double distanceInKilometers = distanceInMiles * kilometersPerMile;

        Console.WriteLine("{0:F2}", distanceInKilometers);
    }
}
