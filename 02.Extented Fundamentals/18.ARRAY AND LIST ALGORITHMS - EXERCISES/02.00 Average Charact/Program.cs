using System;
using System.Linq;
public class AverageCharacterDelimiter
{
    public static void Main() // 100/100
    {
        string[] inputCharArray = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

        char[] charArray = string.Join(string.Empty, inputCharArray).ToCharArray();

        int len = charArray.Length;
        int sum = 0;

        foreach (char letter in charArray)
        {
            sum += letter;
        }
        char charToAdd = (char)(sum / len);
        char delimiter = char.ToUpper(charToAdd);

        Console.WriteLine(string.Join($"{delimiter}", inputCharArray));
    }
}