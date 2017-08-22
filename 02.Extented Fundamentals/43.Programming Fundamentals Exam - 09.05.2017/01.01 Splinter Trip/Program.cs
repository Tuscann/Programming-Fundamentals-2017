using System;

public class SplinterTrip
{
    public static void Main() // 100/100
    {
        decimal distance = Convert.ToDecimal(Console.ReadLine());
        decimal fuelCapacity = Convert.ToDecimal(Console.ReadLine());
        decimal spendMiles = Convert.ToDecimal(Console.ReadLine());

        decimal fuelInHeavyWinds = spendMiles * 25m * 1.5m;
        decimal fuelInNoneHeavyWinds = (distance - spendMiles) * 25m;

        decimal totalFuelNeeded = (fuelInNoneHeavyWinds + fuelInHeavyWinds) * 1.05m;
        Console.WriteLine($"Fuel needed: {totalFuelNeeded:F2}L");

        Console.WriteLine(totalFuelNeeded <= fuelCapacity ?
            $"Enough with {(fuelCapacity - totalFuelNeeded):F2}L to spare!" :
            $"We need {(totalFuelNeeded - fuelCapacity):F2}L more fuel.");
    }
}