using System;
class Program
{
    static void Main()
    {
        double distance = double.Parse(Console.ReadLine());
        double tankCapacity = double.Parse(Console.ReadLine());
        double milesInHeavyWind = double.Parse(Console.ReadLine());

        double sum = (distance - milesInHeavyWind) * 25;
        double winwdsConsumption = milesInHeavyWind * 25 * 1.5;

        double tolerance = 1.05 * (sum + winwdsConsumption);

        Console.WriteLine("Fuel needed: {0:f2}L", tolerance);

        if (tankCapacity >= tolerance)
        {
            Console.WriteLine("Enough with {0:f2}L to spare!",tankCapacity-tolerance);
        }
        else
        {
            Console.WriteLine("We need {0:f2}L more fuel.", tolerance - tankCapacity );
        }
    }
}