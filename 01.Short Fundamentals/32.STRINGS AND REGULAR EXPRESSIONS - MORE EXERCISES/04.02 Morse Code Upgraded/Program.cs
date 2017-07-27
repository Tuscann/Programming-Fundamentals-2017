using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main() // 100/100
    {
        string[] inputLine = Console.ReadLine().Split('|');

        string solution = string.Empty;

        foreach (var morse in inputLine)
        {
            int totalSum = 0;

            int addZeroes = Regex.Matches(Regex.Escape(morse), "0").Count;
            int addOnes = Regex.Matches(Regex.Escape(morse), "1").Count;

            totalSum = addOnes * 5 + addZeroes * 3;

            Regex getSequences = new Regex(@"0{2,}|1{2,}");

            var matchedSequences = getSequences.Matches(morse);

            foreach (Match sequence in matchedSequences)
            {
                totalSum += sequence.Length;
            }

            solution += (char)totalSum;
        }
        Console.WriteLine(solution);
    }
}
