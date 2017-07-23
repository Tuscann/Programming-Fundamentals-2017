using System;
class Program
{
    static void Main()
    {
        string[] lineOfWords = Console.ReadLine().Split();

        char[] firstWord = lineOfWords[0].ToCharArray();
        char[] secondWord = lineOfWords[1].ToCharArray();

        long sum = 0;

        if (firstWord.Length >= secondWord.Length)
        {
            for (int cycle1 = 0; cycle1 < secondWord.Length; cycle1++)
            {
                sum += firstWord[cycle1] * secondWord[cycle1];
            }

            for (int cycle2 = secondWord.Length; cycle2 < firstWord.Length; cycle2++)
            {
                sum += firstWord[cycle2];
            }
        }
        else
        {
            for (int cycle1 = 0; cycle1 < firstWord.Length; cycle1++)
            {
                sum += firstWord[cycle1] * secondWord[cycle1];
            }

            for (int cycle2 = firstWord.Length; cycle2 < secondWord.Length; cycle2++)
            {
                sum += secondWord[cycle2];
            }
        }

        Console.WriteLine(sum);
    }
}