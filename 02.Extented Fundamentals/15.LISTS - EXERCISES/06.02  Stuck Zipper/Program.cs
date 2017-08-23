using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<int> firstLetter = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        List<int> secondLetters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        int firstLetterMinDigit = CalculateMaxDigit(firstLetter);
        int secondLetterMinDigit = CalculateMaxDigit(secondLetters);
        int minDigit = Math.Min(firstLetterMinDigit, secondLetterMinDigit);

        List<int> firstLetterAfterRemoval = new List<int>();
        List<int> secondLetterAfterRemoval = new List<int>();

        for (int i = 0; i < firstLetter.Count; i++)
        {
            if (firstLetter[i] / minDigit <= 0) firstLetterAfterRemoval.Add(firstLetter[i]);
        }
        for (int i = 0; i < secondLetters.Count; i++)
        {
            if (secondLetters[i] / minDigit <= 0) secondLetterAfterRemoval.Add(secondLetters[i]);
        }
        int maxLenght = Math.Max(firstLetterAfterRemoval.Count, secondLetterAfterRemoval.Count);
        List<int> combineLetter = new List<int>();
        for (int i = 0; i < maxLenght; i++)
        {
            if (i < secondLetterAfterRemoval.Count)
            {
                combineLetter.Add(secondLetterAfterRemoval[i]);
            }
            if (i < firstLetterAfterRemoval.Count)
            {
                combineLetter.Add(firstLetterAfterRemoval[i]);
            }
        }
        Console.WriteLine(string.Join(" ", combineLetter));
    }
    private static int CalculateMaxDigit(List<int> letter)
    {
        int mindigit = int.MaxValue;

        for (int i = 0; i < letter.Count; i++)
        {
            int currentdigit = 1;
            int temp = Math.Abs(letter[i]);
            while (true)
            {
                if (temp / 10 == 0)
                {
                    break;
                }
                currentdigit *= 10;
                temp = temp / 10;
            }
            mindigit = Math.Min(mindigit, currentdigit);
        }
        return mindigit * 10;
    }
}