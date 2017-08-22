using System;
public class Program
{
    public static void Main() // 100/100
    {
        long n = long.Parse(Console.ReadLine());

        decimal techicalTrainersSum = 0;
        decimal theoreticalTrainersSum = 0;
        decimal practcalTrainersSum = 0;

        for (int i = 0; i < n; i++)
        {
            long distanceInMeters = long.Parse(Console.ReadLine()) * 1600;
            decimal cargoInKilograms = decimal.Parse(Console.ReadLine()) * 1000;
            string teamName = Console.ReadLine();

            decimal cargoIncome = 1.5m * cargoInKilograms;
            decimal fuelConsumption = 0.7m * distanceInMeters * 2.5m;

            decimal participantEarnedMoney = cargoIncome - fuelConsumption;

            if (teamName == "Technical")
            {
                techicalTrainersSum += participantEarnedMoney;
            }
            else if (teamName == "Practical")
            {
                practcalTrainersSum += participantEarnedMoney;
            }
            else if (teamName == "Theoretical")
            {
                theoreticalTrainersSum += participantEarnedMoney;
            }
        }

        decimal winTeamSum = Math.Max(theoreticalTrainersSum, Math.Max(techicalTrainersSum, practcalTrainersSum));

        if (winTeamSum == theoreticalTrainersSum)
        {
            Console.WriteLine($"The Theoretical Trainers win with ${theoreticalTrainersSum:F3}.");
        }
        else if (winTeamSum == techicalTrainersSum)
        {
            Console.WriteLine($"The Technical Trainers win with ${techicalTrainersSum:F3}.");
        }
        else if (winTeamSum == practcalTrainersSum)
        {
            Console.WriteLine($"The Practical Trainers win with ${practcalTrainersSum:F3}.");
        }
    }
}