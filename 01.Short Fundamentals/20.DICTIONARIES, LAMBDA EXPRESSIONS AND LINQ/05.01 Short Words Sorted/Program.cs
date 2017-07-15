using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> text = Console.ReadLine()
            .ToLower()
            .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' },
                StringSplitOptions.RemoveEmptyEntries)
            .Where(x => x.Length < 5)
            .Distinct()
            .OrderBy(x => x)
            .ToList();

        Console.WriteLine(string.Join(", ", text));
    }
}
