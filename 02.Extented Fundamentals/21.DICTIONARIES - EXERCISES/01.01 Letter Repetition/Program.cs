using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string letters = Console.ReadLine();
        char[] splitLetters = letters.ToCharArray();
        Dictionary<char, int> answer = new Dictionary<char, int>();

        foreach (var character in splitLetters)
        {
            if (!answer.ContainsKey(character))
            {
                answer.Add(character, 0);
            }
            answer[character]++;
        }

        foreach (var kvp in answer)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}
