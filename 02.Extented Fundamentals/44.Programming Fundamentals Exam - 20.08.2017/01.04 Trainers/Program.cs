using System;
public class Trainers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double fuelPrice = 2.5;
        double cargoPrice = 1.5;

        double technicalTotal = 0.0;
        double theoreticalTotal = 0.0;
        double practicalTotal = 0.0;

        string resultTeamName = "";

        for (int i = 0; i < n; i++)
        {
            int distanceMiles = int.Parse(Console.ReadLine());
            double cargoTones = double.Parse(Console.ReadLine());
            string teamName = Console.ReadLine();

            int distanceInMeters = distanceMiles * 1600;
            double cargoKg = cargoTones * 1000;

            double fuelCons = 0.7 * distanceInMeters * fuelPrice;

            double cargoMoney = cargoPrice * cargoKg;

            double teamCoast = cargoMoney - fuelCons;

            if (teamName == "Technical")
            {
                technicalTotal += teamCoast;
            }
            else if (teamName == "Theoretical")
            {
                theoreticalTotal += teamCoast;
            }
            else if (teamName == "Practical")
            {
                practicalTotal += teamCoast;
            }
        }

        double firstRes = Math.Max(technicalTotal, theoreticalTotal);

        if (firstRes == technicalTotal)
        {
            resultTeamName = "Technical";
        }
        else
        {
            resultTeamName = "Theoretical";
        }

        double result = Math.Max(firstRes, practicalTotal);

        if (result == practicalTotal)
        {
            resultTeamName = "Practical";
        }

        Console.WriteLine($"The {resultTeamName} Trainers win with ${result:f3}.");
    }
}