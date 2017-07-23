using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var bannedWords = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var text = Console.ReadLine();
        
        foreach (var word in bannedWords)
        {
            int startIndex = text.IndexOf(word);
            int wordLenght = word.Length;
            string newValue = new string('*', word.Length);
            string oldValue = text.Substring(startIndex, wordLenght);

            text = text.Replace(oldValue, newValue);
        }
        Console.WriteLine(text);
    }
}