using System;
public class Trainers
{
    public static void Main() // 100/100
    {
        int participants = Convert.ToInt32(Console.ReadLine());

        double technicalTeamSum = 0.0;
        double theoreticalTeamSum = 0.0;
        double practicalTeamSum = 0.0;


        for (int count = 0; count < participants; count++)
        {
            long distanceToTravel = Convert.ToInt64(Console.ReadLine());
            double cargo = Convert.ToDouble(Console.ReadLine());
            string team = Console.ReadLine().ToLower();
            
            if (team == "technical")
            {
                technicalTeamSum += cargo * 1000 * 1.5 - distanceToTravel * 1600 * 0.7 * 2.5;
            }
            if (team == "theoretical")
            {
                theoreticalTeamSum += cargo * 1000 * 1.5 - distanceToTravel * 1600 * 0.7 * 2.5;
            }
            if (team == "practical")
            {
                practicalTeamSum += cargo * 1000 * 1.5 - distanceToTravel * 1600 * 0.7 * 2.5;
            }
        }

        double winnerSum = Math.Max(technicalTeamSum, Math.Max(theoreticalTeamSum, practicalTeamSum));

        if (winnerSum == technicalTeamSum)
        {
            Console.WriteLine($"The Technical Trainers win with ${Math.Round(winnerSum, 3):F3}.");
        }
        else if (winnerSum == theoreticalTeamSum)
        {
            Console.WriteLine($"The Theoretical Trainers win with ${Math.Round(winnerSum, 3):F3}.");
        }
        else if (winnerSum == practicalTeamSum)
        {
            Console.WriteLine($"The Practical Trainers win with ${Math.Round(winnerSum, 3):F3}.");
        }
    }
}