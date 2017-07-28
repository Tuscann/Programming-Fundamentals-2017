using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Morse_Code_Upgraded
{
    public static void Main()
    {
        var messageLetters = Console.ReadLine()
            .Split('|')
            .ToList();

        var decipheredMessage = new StringBuilder();

        foreach (var messageLetter in messageLetters)
        {
            var zeroesCount = messageLetter.Count(x => x == '0');

            var onesCount = messageLetter.Count(x => x == '1');

            var currentSum = zeroesCount * 3 + onesCount * 5;

            var equalDigitsCount = 1;

            for (int i = 0; i < messageLetter.Length - 1; i++)
            {
                var currentDigit = messageLetter[i];
                var nextDigit = messageLetter[i + 1];

                if (currentDigit == nextDigit)
                {
                    equalDigitsCount++;
                }

                else
                {
                    if (equalDigitsCount == 1)
                    {
                        continue;
                    }

                    currentSum += equalDigitsCount;
                    equalDigitsCount = 1;
                }

                if (equalDigitsCount != 1)
                {
                    currentSum += equalDigitsCount;
                }

                
            }
            decipheredMessage.Append((char)currentSum);
        }

        Console.WriteLine(decipheredMessage.ToString());
    }
}