using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var smallLeters = new List<string>();
        var upperLeters = new List<string>();
        var mixedlLeters = new List<string>();

        var input = Console.ReadLine().Split(new char[] { '|', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        foreach (var word in input)
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
