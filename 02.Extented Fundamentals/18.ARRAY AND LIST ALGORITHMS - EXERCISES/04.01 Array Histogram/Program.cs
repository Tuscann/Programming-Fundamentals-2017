using System;
using System.Collections.Generic;
using System.Linq;
public class ArrayHistogram
{
    public static void Main()
    {
        string[] words = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();
        
        List<string> foundWords = new List<string>();  //Holds Unique Words
        List<int> wordCount = new List<int>();   //Holds Word Occurences

        for (int i = 0; i < words.Length; i++)
        {
            string currendWord = words[i];

            if (foundWords.Contains(currendWord))
            {
                int wordIndex = foundWords.IndexOf(currendWord);
                wordCount[wordIndex]++;
            }
            else
            {
                foundWords.Add(currendWord);
                wordCount.Add(1);
            }
        }
        bool hasSwapped = true;

        //Bubble sord
        while (hasSwapped)
        {
            hasSwapped = false;
            for (int i = 0; i < wordCount.Count - 1; i++)
            {
                //Bubble
                if (wordCount[i] < wordCount[i + 1])
                {
                    int temp = wordCount[i];
                    wordCount[i] = wordCount[i + 1];
                    wordCount[i + 1] = temp;

                    string tempWord = foundWords[i];
                    foundWords[i] = foundWords[i + 1];
                    foundWords[i + 1] = tempWord;

                    hasSwapped = true;
                }
            }
        }

        for (int i = 0; i < foundWords.Count; i++)
        {
            double currentPercentage = wordCount[i] * 100.0/ words.Length;

            Console.WriteLine("{0} -> {1} times ({2:F2}%)", foundWords[i], wordCount[i], currentPercentage);
        }
    }
}