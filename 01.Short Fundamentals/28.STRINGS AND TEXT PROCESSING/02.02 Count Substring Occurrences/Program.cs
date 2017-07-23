using System;
public class CountSubstringOccurrences
{
    public static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string word = Console.ReadLine().ToLower();
        int count = 0;

        int indexOfOccurence = text.IndexOf(word, 0);

        while (indexOfOccurence >= 0)
        {
            count++;
            indexOfOccurence = text.IndexOf(word, indexOfOccurence + 1);
        }

        Console.WriteLine(count);
    }
}