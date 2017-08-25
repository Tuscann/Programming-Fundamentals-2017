using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        string[] lineOfWords = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' },
            StringSplitOptions.RemoveEmptyEntries);

        List<string> solution = new List<string>();

        foreach (string word in lineOfWords)
        {
            if (word.SequenceEqual(word.Reverse()) && !solution.Contains(word))
            {
                solution.Add(word);
            }
        }
        solution.Sort();

        Console.WriteLine(string.Join(", ", solution));
    }
}
