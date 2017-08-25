using System;
public class Program
{
    public static void Main() // 100/100
    {
        string[] bannedWords = Console.ReadLine().Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        string inputText = Console.ReadLine();

        foreach (var word in bannedWords)
        {
            inputText = inputText
                .Replace(word, new string('*', word.Length));
        }
        Console.WriteLine(inputText);
    }
}