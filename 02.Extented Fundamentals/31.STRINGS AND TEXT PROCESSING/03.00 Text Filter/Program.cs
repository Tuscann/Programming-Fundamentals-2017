using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<string> bannedWords = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        string text = Console.ReadLine();

        foreach (string word in bannedWords)
        {
            int startIndex = text.IndexOf(word);
            int wordLenght = word.Length;
            string newValue = new string('*', word.Length);
            string oldValue = text.Substring(startIndex, wordLenght);

            text = text.Replace(oldValue, newValue);
        }
        Console.WriteLine(text);
    }
}