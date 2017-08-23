using System;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main() // 100/100
    {
        string pattern = @"^(\<\[[^A-Za-z0-9]*\][\.]{1})+([\.]{1}\[[A-Za-z0-9]*\][\.]{1})*$";

        string inputLine = Console.ReadLine();

        while (inputLine != "Traincode!")
        {
            Match train = Regex.Match(inputLine,pattern);

            if (train.Success)
            {
                Console.WriteLine(inputLine);
            }
            inputLine = Console.ReadLine();
        }
    }
}