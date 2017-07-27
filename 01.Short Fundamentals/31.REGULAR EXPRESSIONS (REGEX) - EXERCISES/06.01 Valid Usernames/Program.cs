using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main()  // 100/100
    {
        char[] delimiters = " ,/\\()".ToCharArray();
        string input = Console.ReadLine();

        string usernameValidationPattern = @"\b[A-Za-z]\w{2,24}\b";
        var regex = new Regex(usernameValidationPattern);

        List<string> namesForValidation = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

        for (int i = 0; i < namesForValidation.Count; i++)
        {
            if (!regex.IsMatch(namesForValidation[i]))
            {
                namesForValidation.RemoveAt(i);
                i--;
            }
        }

        int highestLenghtsSum = int.MinValue;
        string usernamesToPrint = string.Empty;

        for (int i = 0; i < namesForValidation.Count - 1; i++)
        {
            int currentSum = namesForValidation[i].Length + namesForValidation[i + 1].Length;

            if (currentSum > highestLenghtsSum)
            {
                highestLenghtsSum = currentSum;
                usernamesToPrint = namesForValidation[i] + Environment.NewLine + namesForValidation[i + 1];
            }
        }

        Console.WriteLine(usernamesToPrint);
    }
}