using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().ToList();

        string firstWord = input[0];
        string secondWord = input[1];

        int minLength = Math.Min(firstWord.Length, secondWord.Length);
        bool areExchangeable = true;

        Dictionary<char, char> charachters = new Dictionary<char, char>();


        for (int i = 0; i < minLength; i++)
        {
            char firstChar = firstWord[i];
            char secondChar = secondWord[i];

            if (!charachters.ContainsKey(firstChar) && !charachters.ContainsValue(secondChar))
            {
                charachters.Add(firstChar, secondChar);
            }
            else if (charachters.ContainsKey(firstChar) && charachters[firstChar] == secondChar)
            {
                continue;
            }
            else if (charachters.ContainsKey(firstChar) && charachters[firstChar] != secondChar)
            {
                areExchangeable = false;
                break;
            }
            else if (!charachters.ContainsKey(firstChar) && charachters.ContainsValue(secondChar))
            {
                areExchangeable = false;
                break;
            }
        }
        if (firstWord.Length < secondWord.Length)
        {
            for (int i = firstWord.Length; i < secondWord.Length; i++)
            {
                if (!charachters.ContainsValue(secondWord[i]))
                {
                    areExchangeable = false;
                    break;
                }
            }
        }
        else if (firstWord.Length > secondWord.Length)
        {
            for (int i = secondWord.Length; i < firstWord.Length; i++)
            {
                if (!charachters.ContainsKey(firstWord[i]))
                {
                    areExchangeable = false;
                    break;
                }
            }
        }

        if (areExchangeable)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}