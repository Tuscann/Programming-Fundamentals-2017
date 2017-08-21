using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class RageQuit
{
    static void Main() // 100/100
    {
        StringBuilder finalSymbolSequence = new StringBuilder();

        string stringNumberSequences = Console.ReadLine();

        MatchNumberSequences(stringNumberSequences, finalSymbolSequence);

        int uniqueSymbolsCount = finalSymbolSequence.ToString().Distinct().Count();

        Console.WriteLine("Unique symbols used: {0}", uniqueSymbolsCount);
        Console.WriteLine(finalSymbolSequence.ToString());
    }

    private static void MatchNumberSequences(string stringNumberSequences, StringBuilder finalSymbolSequence)
    {
        const string StringNumberPattern = @"([^0-9]+)([0-9]+)";
        Regex stringNumbers = new Regex(StringNumberPattern);

        MatchCollection inputStrings = stringNumbers.Matches(stringNumberSequences);

        ProcessStringNumberSequences(finalSymbolSequence, inputStrings);
    }

    private static void ProcessStringNumberSequences(StringBuilder finalSymbolSequence, MatchCollection inputStrings)
    {
        for (int i = 0; i < inputStrings.Count; i++)
        {
            string symbolSequence = inputStrings[i].Groups[1].Value.ToUpper();
            int timesToReapeat = int.Parse(inputStrings[i].Groups[2].Value);

            string replacer = string.Concat(Enumerable.Repeat(symbolSequence, timesToReapeat));

            finalSymbolSequence.Append(replacer);
        }
    }
}