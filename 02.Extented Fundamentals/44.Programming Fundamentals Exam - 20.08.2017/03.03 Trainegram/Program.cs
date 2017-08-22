using System;
using System.Text.RegularExpressions;
public class Trainlands
{
    public static void Main() // 100/100
    {
        string pattern = @"^<\[([^a-zA-Z0-9]*)\]\.(\.\[([a-zA-Z0-9]*)\]\.)*$";

        while (true)
        {
            string composition = Console.ReadLine();
            Match match = Regex.Match(composition, pattern);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
            if (composition == "Traincode!")
            {
                return;
            }
        }
    }
}