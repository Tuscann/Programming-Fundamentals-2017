using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()  // 80/100
    {
        string input = Console.ReadLine();
        string happyPattern = @"(\:\)|\:D|;\)|\:\*|\:]|;]|\:}|;}|\(\:|\*\:|c\:|\[\:|\[;)";
        string sadPattern = @"(\:\(|D\:|;\(|\:\[|;\[\||\:{|;{|\)\:|\:c|]\:|];)";

        MatchCollection happy = Regex.Matches(input, happyPattern);
        MatchCollection sad = Regex.Matches(input, sadPattern);

        double happyyIndex = happy.Count / (double)sad.Count;

        if (happyyIndex >= 2.00)
        {
            Console.WriteLine("Happiness index: {0:f2} :D", happyyIndex);
            Console.WriteLine("[Happy count: {0}, Sad count: {1}]", happy.Count, sad.Count);
        }
        else if (happyyIndex > 1 && happyyIndex < 2.00)
        {
            Console.WriteLine("Happiness index: {0:f2} :)", happyyIndex);
            Console.WriteLine("[Happy count: {0}, Sad count: {1}]", happy.Count, sad.Count);
        }
        else if (happyyIndex == 1.00)
        {
            Console.WriteLine("Happiness index: {0:f2} :|", happyyIndex);
            Console.WriteLine("[Happy count: {0}, Sad count: {1}]", happy.Count, sad.Count);
        }
        else if (happyyIndex < 1.00)
        {
            Console.WriteLine("Happiness index: {0:f2} :(", happyyIndex);
            Console.WriteLine("[Happy count: {0}, Sad count: {1}]", happy.Count, sad.Count);
        }

    }
}