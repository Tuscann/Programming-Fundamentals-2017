using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main() // 100/100
    {
        Regex didimon01 = new Regex(@"([^A-Za-z\-]+)");
        Regex bojomon02 = new Regex(@"([A-Za-z]+-[A-Za-z]+)");

        string inputLine = Console.ReadLine();

        bool lamp = false;
        int counter = 0;

        while (lamp != true)
        {
            if (counter % 2 == 0)
            {
                Match match = didimon01.Match(inputLine);
                if (match.Success)
                {
                    string valueAndStart = match.Value;
                    Console.WriteLine(match.Value);
                    int remove = inputLine.IndexOf(valueAndStart);
                    inputLine = inputLine.Remove(0, valueAndStart.Length + remove);
                }
                else
                {
                    lamp = true;
                }
            }
            else if (counter % 2 != 0)
            {
                Match match = bojomon02.Match(inputLine);
                if (match.Success)
                {
                    string valueAndStart = match.Value;
                    Console.WriteLine(match.Value);
                    int remove = inputLine.IndexOf(valueAndStart);
                    inputLine = inputLine.Remove(0, valueAndStart.Length + remove);
                }
                else
                {
                    lamp = true;
                }
            }
            counter++;
        }

    }
}