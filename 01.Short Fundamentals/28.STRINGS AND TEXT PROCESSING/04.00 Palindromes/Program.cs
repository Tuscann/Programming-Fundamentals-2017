using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var lineOfWords = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' },
            StringSplitOptions.RemoveEmptyEntries);

        List<string> solution = new List<string>();

        foreach (var word in lineOfWords)
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
