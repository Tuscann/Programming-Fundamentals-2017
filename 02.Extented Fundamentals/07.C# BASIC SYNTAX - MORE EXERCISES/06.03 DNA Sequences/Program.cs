using System;
class P06_DnaSequences
{
    static void Main()
    {
        int dnaSum = int.Parse(Console.ReadLine());
        char[] dna = new char[] { 'O', 'A', 'C', 'G', 'T', 'X' };
        int counter = 0;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    counter++;
                    if (i + j + k >= dnaSum)
                    {
                        Console.Write("{0}{1}{2}{3}{0} ", dna[0], dna[i], dna[j], dna[k]);
                    }
                    else
                    {
                        Console.Write("{0}{1}{2}{3}{0} ", dna[5], dna[i], dna[j], dna[k]);
                    }

                    if (counter % 4 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}