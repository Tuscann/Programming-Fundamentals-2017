using System;
class Program
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());

        
        double min = double.MinValue;

        double sumTechical = 0;
        double sumTheoretical = 0;
        double sumPractical = 0;

        for (int i = 0; i < numbers; i++)
        {
            double distanceTravel = double.Parse(Console.ReadLine());
            double cargo = double.Parse(Console.ReadLine());
            string currentName = Console.ReadLine().Trim();

            double sum = (cargo * 10 * 1.5) - (0.7 * distanceTravel * 16 * 2.5);

            if (currentName == "Technical")
            {
                sumTechical += sum;
            }
            if (currentName == "Theoretical")
            {
                sumTheoretical += sum;
            }
            if (currentName == "Practical")
            {
                sumPractical += sum;
            }           
        }

        double minn = Math.Max(sumTechical, Math.Max(sumTheoretical, sumPractical));
        string name = string.Empty;

        if (minn== sumTechical)
        {
            name = "Technical";
        }
        if (minn == sumTheoretical)
        {
            name = "Theoretical";
        }
        if (minn == sumPractical)
        {
            name = "Practical";
        }


        Console.WriteLine("The {0} Trainers win with ${1:f3}.", name, minn * 100);
    }
}

