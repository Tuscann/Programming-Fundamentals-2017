using System;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main()  // 100/100
    {
        Regex split = new Regex(@"([a-zA-Z]*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)(\w+)");
        
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        string start = "";
        string end = "";

        var matcher = split.Matches(firstInput);
        foreach (Match match in matcher)
        {
            start = match.Groups[1].Value.ToString();
            end = match.Groups[2].Value.ToString();
        }

        var solution = new StringBuilder();

        int indexerStart = 0;
        int indexerEnd = 0;

        for (int i = 0; i < secondInput.Length; i++)
        {
            int firstOccasion = secondInput.IndexOf(start, indexerStart);
            if (firstOccasion == -1)
            {
                break;
            }
            int secondOccasion = secondInput.IndexOf(end, indexerEnd);

            if (firstOccasion != -1 && secondOccasion != -1)
            {
                solution.Append(secondInput, firstOccasion + start.Length, secondOccasion - firstOccasion - start.Length);

                indexerStart = secondOccasion + end.Length;
                indexerEnd = indexerStart + 1;
            }
            //e tui ako proraboti si reja tashacite
        }
        if (solution.Length > 0)
        {
            Console.WriteLine(solution);
        }
        else
        {
            Console.WriteLine("Empty result");
        }
    }
}