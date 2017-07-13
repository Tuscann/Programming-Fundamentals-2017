using System;
using System.Collections.Generic;
class Split_by_Word_Casing
{
    static void Main()
    {
        char[] separators = ",;:.!()\"'/\\[] ".ToCharArray();
        string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

        List<string> lowercaseWords = new List<string>();
        List<string> uppercaseWords = new List<string>();
        List<string> mixedcaseWords = new List<string>();

        foreach (string word in words)
        {
            bool containsLower = false;
            bool containsUpper = false;
            bool containsSymbol = false;
            foreach (char letter in word)
            {
                if (!char.IsLetter(letter)) containsSymbol = true;
                else if (char.IsUpper(letter)) containsUpper = true;
                else if (char.IsLower(letter)) containsLower = true;
            }
            if (containsSymbol) mixedcaseWords.Add(word);
            else if (!containsLower) uppercaseWords.Add(word);
            else if (!containsUpper) lowercaseWords.Add(word);
            else mixedcaseWords.Add(word);
        }
        Console.WriteLine("Lower-case: {0}", string.Join(", ", lowercaseWords));
        Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedcaseWords));
        Console.WriteLine("Upper-case: {0}", string.Join(", ", uppercaseWords));
    }
}
