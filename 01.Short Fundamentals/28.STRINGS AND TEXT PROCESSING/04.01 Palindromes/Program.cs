using System;
using System.Collections.Generic;

public class Palindromes
{
    public static void Main()
    {
        char[] symbols = new char[] { ' ', ',', '.', '?', '!' };
        string[] text = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries);
        List<string> palindromes = new List<string>();

        foreach (var word in text)
        {
            string reversedWord = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            if (word.Equals(reversedWord) && !palindromes.Contains(word))
            {
                palindromes.Add(word);
            }
        }

        palindromes.Sort();

        Console.WriteLine(string.Join(", ", palindromes));
    }
}