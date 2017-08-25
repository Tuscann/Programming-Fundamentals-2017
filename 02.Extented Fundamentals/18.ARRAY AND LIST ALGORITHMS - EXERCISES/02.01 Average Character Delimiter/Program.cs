using System;
class Program
{
    static void Main() // 100/100
    {
        string[] averageCharArray = Console.ReadLine().Split();

        int averageChars = SplittingTheArray(averageCharArray);

        for (int answerCycle = 0; answerCycle < averageCharArray.Length; answerCycle++)
        {
            if (answerCycle == averageCharArray.Length - 1)
            {
                Console.WriteLine(averageCharArray[answerCycle]);
            }
            else
            {
                if (averageChars >= 97 && averageChars <= 122)
                {
                    averageChars -= 32;
                }
                Console.Write(averageCharArray[answerCycle] + (char)averageChars);
            }
        }
    }

    static int SplittingTheArray(string[] averageCA)
    {
        double sumOfChars = 0;
        double totalChars = 0;

        for (int cycleToChar = 0; cycleToChar < averageCA.Length; cycleToChar++)
        {
            string givenWord = averageCA[cycleToChar];
            givenWord.ToCharArray();
            foreach (char letter in givenWord)
            {
                sumOfChars += letter;
                totalChars++;
            }
        }
        int averageChars = (int)Math.Floor(sumOfChars / totalChars);
        return averageChars;
    }
}