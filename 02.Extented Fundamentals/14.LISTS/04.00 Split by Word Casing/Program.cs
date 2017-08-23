using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<string> smallLeters = new List<string>();
        List<string> upperLeters = new List<string>();
        List<string> mixedlLeters = new List<string>();

        List<string> input = Console.ReadLine().Split(new char[] { '|', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        foreach (string word in input)
        {
            if (word.All(char.IsUpper))
            {
                upperLeters.Add(word);
            }
            else if (word.All(char.IsLower))
            {
                smallLeters.Add(word);
            }
            else
            {
                mixedlLeters.Add(word);
            }
        }
        Console.WriteLine("Lower-case: {0}", string.Join(", ", smallLeters));
        Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedlLeters));
        Console.WriteLine("Upper-case: {0}", string.Join(", ", upperLeters));
    }
}