using System;
using System.Collections.Generic;
using System.Linq;

public class CapitalizeWords
{
    public static void Main() // 100/100 not my solution
    {
        char[] symbols = new char[] { '.', ',', '-', '_', '!', '"', '?', ':', ';', '(', ')', '{', '}', '[', ']', '§'

            , '$', '%', '&', '/', '\\', '=', '|', '^', '°', '*', '#', '+', '~', '²', '³', '<', '>', ' '};

        List<string> currentSentense = Console.ReadLine().ToLower().Split(symbols, StringSplitOptions.RemoveEmptyEntries).ToList();

        while (currentSentense[0] != "end")
        {
            List<string> newSentence = new List<string>();

            foreach (string symbol in currentSentense)
            {
                string newWord = string.Empty; ;

                for (int singht = 0; singht < symbol.Length; singht++)
                {
                    string currentChar = symbol[singht].ToString();

                    if (singht == 0)
                    {
                        currentChar = symbol[singht].ToString().ToUpper();
                    }

                    newWord += currentChar;
                }

                newSentence.Add(newWord);
            }

            Console.WriteLine(string.Join(", ", newSentence));

            currentSentense = Console.ReadLine().ToLower().Split(symbols, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
}