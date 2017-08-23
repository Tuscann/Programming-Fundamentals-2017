using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Program
{
    public static void Main()
    {

        string[] textWords = File.ReadAllText("text.txt")
            .ToLower()
            .Split(new[] { ' ', '-', ',', '?', '!', '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries);

        string[] wordsToFind = File.ReadAllText("words.txt")
            .ToLower()
            .Split();

        Dictionary<string, int> words = new Dictionary<string, int>();

        for (int i = 0; i < wordsToFind.Length; i++)
        {
            string word = wordsToFind[i];
            words[word] = 0;
        }

        for (int i = 0; i < textWords.Length; i++)
        {
            string currentWord = textWords[i];
            if (words.ContainsKey(currentWord))
            {
                words[currentWord]++;
            }
        }

        words = words
            .OrderByDescending(w => w.Value)
            .ToDictionary(w => w.Key, w => w.Value);

        foreach (var word in words)
        {
            File.AppendAllText("WordCount.txt",
                $"{word.Key} - {word.Value}" + Environment.NewLine);
        }

    }
}