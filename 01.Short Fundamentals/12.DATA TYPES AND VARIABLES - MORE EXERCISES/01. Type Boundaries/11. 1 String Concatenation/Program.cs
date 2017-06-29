using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string delimiter = Console.ReadLine();
        string evenOrOdd = Console.ReadLine();
        int numberOfInputWords = int.Parse(Console.ReadLine());

        List<string> allWords = new List<string>();

        for (int i = 1; i <= numberOfInputWords; i++)
        {
            string currentWord = Console.ReadLine();
            if (evenOrOdd == "even" && i % 2 == 0)
            {
                allWords.Add(currentWord);
            }
            else if (evenOrOdd == "odd" && i % 2 != 0)
            {
                allWords.Add(currentWord);
            }
        }
        Console.WriteLine(string.Join(delimiter, allWords));
    }
}