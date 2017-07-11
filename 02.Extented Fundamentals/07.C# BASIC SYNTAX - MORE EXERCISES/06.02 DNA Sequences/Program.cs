using System;
class Program
{
    enum nucleotides
    {
        A = 1,
        C = 2,
        G = 3,
        T = 4
    };

    static void Main()
    {
        int matchSum = int.Parse(Console.ReadLine());
        int counter = 0;

        for (nucleotides first = nucleotides.A; first <= nucleotides.T; first++)
        {
            for (nucleotides second = nucleotides.A; second <= nucleotides.T; second++)
            {
                for (nucleotides third = nucleotides.A; third <= nucleotides.T; third++)
                {
                    int sum = (int)third + (int)second + (int)first;

                    if (counter % 4 == 0)
                    {
                        Console.WriteLine();
                    }

                    if (sum >= matchSum)
                    {
                        Console.Write($"O{first}{second}{third}O ");
                    }
                    else
                    {
                        Console.Write($"X{first}{second}{third}X ");
                    }
                    counter++;
                }
            }
        }
    }
}