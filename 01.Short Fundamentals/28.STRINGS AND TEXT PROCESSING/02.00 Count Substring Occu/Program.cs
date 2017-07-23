using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        string searchedString = Console.ReadLine().ToLower();

        int count = input.Select((c, i) => input.Substring(i)).Count(sub => sub.StartsWith(searchedString));

        Console.WriteLine(count);
    }
}