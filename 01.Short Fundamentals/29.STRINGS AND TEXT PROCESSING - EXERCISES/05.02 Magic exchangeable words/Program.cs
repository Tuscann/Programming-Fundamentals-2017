using System;
using System.Collections.Generic;
class Program
{
    static void Main()  //80/100
    {
        string[] lineOfWords = Console.ReadLine().Split();
        Dictionary<char, char> splittedWords = new Dictionary<char, char>();
        bool lamp = false;
        char[] firstWord = lineOfWords[0].ToCharArray();
        char[] secondWord = lineOfWords[1].ToCharArray();

        for (int cycle = 0; cycle < Math.Min(firstWord.Length, secondWord.Length); cycle++)
        {
            if (!splittedWords.ContainsKey(firstWord[cycle]))
            {
                if (!splittedWords.ContainsValue(secondWord[cycle]))
                {
                    splittedWords.Add(firstWord[cycle], secondWord[cycle]);
                }
            }
            else if (splittedWords[firstWord[cycle]] != secondWord[cycle])
            {
                lamp = true;
                Console.WriteLine("false");
                break;
            }
        }

        if (lamp == false)
        {
            if (firstWord.Length > secondWord.Length)
            {
                for (int cycle2 = secondWord.Length; cycle2 < firstWord.Length; cycle2++)
                {
                    if (!splittedWords.ContainsKey(firstWord[cycle2]))
                    {
                        lamp = true;
                        Console.WriteLine("false");
                        break;
                    }
                }
            }
            else
            {
                for (int cycle3 = firstWord.Length; cycle3 < secondWord.Length; cycle3++)
                {
                    if (!splittedWords.ContainsValue(secondWord[cycle3]))
                    {
                        lamp = true;
                        Console.WriteLine("false");
                        break;
                    }
                }
            }
        }

        if (lamp == false)
        {
            Console.WriteLine("true");
        }
    }
}