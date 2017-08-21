using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 90/100
    {
        string input = Console.ReadLine().ToUpper();
        string wordToRepeat = "";
        string num = "";

        var charList = new HashSet<char>();
        var endList = new List<string>();
        char[] inputChars = input.ToCharArray();
        
        for (int i = 0; i < inputChars.Length; i++)
        {
            if (char.IsDigit(inputChars[i]))
            {
                num += inputChars[i];
                if (i < inputChars.Length - 1)
                {
                    if (char.IsDigit(inputChars[i + 1]))
                    {
                        int doubleNum = int.Parse(inputChars[i] + "" + inputChars[i + 1]);

                        for (int v = 0; v < doubleNum; v++)
                        {
                            endList.Add(wordToRepeat);
                        }
                        wordToRepeat = "";
                        doubleNum = 0;
                    }
                    else
                    {
                        for (int v = 0; v < int.Parse(num); v++)
                        {
                            endList.Add(wordToRepeat);
                        }
                        wordToRepeat = "";
                        num = "";
                    }
                }
                else
                {
                    for (int v = 0; v < int.Parse(num); v++)
                    {
                        endList.Add(wordToRepeat);
                    }
                    wordToRepeat = "";
                    num = "";
                }
            }
            else
            {
                wordToRepeat += char.ToUpper(inputChars[i]);
            }
            if (!char.IsDigit(inputChars[i]))
            {
                charList.Add(inputChars[i]);
            }
        }
        Console.WriteLine($"Unique symbols used: {charList.Count}");
        Console.WriteLine(string.Join("", endList));
    }
}