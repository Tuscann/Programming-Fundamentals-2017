using System;
class DNASequences
{
    static void Main(string[] args)
    {
        int matchSum = int.Parse(Console.ReadLine());

        char[] nuclenicAcid = { 'A', 'C', 'G', 'T' };

        for (int firstNuclenic = 0; firstNuclenic < nuclenicAcid.Length; firstNuclenic++)
        {
            for (int middleNuclenic = 0; middleNuclenic < nuclenicAcid.Length; middleNuclenic++)
            {
                for (int lastNuclenic = 0; lastNuclenic < nuclenicAcid.Length; lastNuclenic++)
                {
                    char envilopeSymbol = 'X';
                    int currentSum = firstNuclenic + middleNuclenic + lastNuclenic + 3;
                    if (currentSum >= matchSum)
                    {
                        envilopeSymbol = 'O';
                    }
                    Console.Write("{0}{1}{2}{3}{0} ",
                        envilopeSymbol,
                        nuclenicAcid[firstNuclenic],
                        nuclenicAcid[middleNuclenic],
                        nuclenicAcid[lastNuclenic]);
                }
                Console.WriteLine();
            }
        }

    }
}