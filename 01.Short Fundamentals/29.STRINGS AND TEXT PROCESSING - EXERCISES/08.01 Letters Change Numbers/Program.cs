using System;
public class LettersChangeNumbers
{
    public static void Main()    // 100/100
    {
        char[] lowerCaseAlphabet = new char[26];
        int index = 0;

        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            lowerCaseAlphabet[index] = letter;
            index++;
        }

        char[] upperCaseAlphabet = new char[26];
        index = 0;

        for (char letter = 'A'; letter <= 'Z'; letter++)
        {
            upperCaseAlphabet[index] = letter;
            index++;
        }

        string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        decimal result = 0m;
        decimal totalResult = 0m;

        for (int i = 0; i < input.Length; i++)
        {
            decimal currentNumber = decimal.Parse(input[i].Substring(1, input[i].Length - 2));
            char firstLetter = char.Parse(input[i].Substring(0, 1));
            char lastLetter = char.Parse(input[i].Substring(input[i].Length - 1, 1));

            if (Char.IsUpper(firstLetter))
            {
                for (int position = 0; position < 26; position++)
                {
                    if (upperCaseAlphabet[position] == firstLetter)
                    {
                        result = currentNumber / (position + 1);
                        break;
                    }
                }
            }
            else if (Char.IsLower(firstLetter))
            {
                for (int position = 0; position < 26; position++)
                {
                    if (lowerCaseAlphabet[position] == firstLetter)
                    {
                        result = currentNumber * (position + 1);
                        break;
                    }
                }
            }

            if (Char.IsUpper(lastLetter))
            {
                for (int position = 0; position < 26; position++)
                {
                    if (upperCaseAlphabet[position] == lastLetter)
                    {
                        totalResult += result - (position + 1);
                        break;
                    }
                }
            }
            else if (Char.IsLower(lastLetter))
            {
                for (int position = 0; position < 26; position++)
                {
                    if (lowerCaseAlphabet[position] == lastLetter)
                    {
                        totalResult += result + (position + 1);
                        break;
                    }
                }
            }
        }
        Console.WriteLine($"{totalResult:f2}");
    }
}