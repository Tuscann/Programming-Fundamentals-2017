using System;
public class Program
{
    public static void Main() // 100/100
    {
        string inputLine = Console.ReadLine();
        string commands = Console.ReadLine();

        while (commands != "end")
        {
            string[] tokens = commands.Split();
            string command = tokens[0];

            switch (command)
            {
                case "Left":
                    int countLeft = int.Parse(tokens[1]);

                    countLeft %= inputLine.Length;
                    inputLine = inputLine
                                    .Substring(countLeft) + inputLine.Substring(0, countLeft);
                    break;
                case "Right":
                    int countRight = int.Parse(tokens[1]);

                    countRight %= inputLine.Length;
                    inputLine = inputLine.Substring(inputLine.Length - countRight) + inputLine.Substring(0, inputLine.Length - countRight);

                    break;
                case "Insert":
                    int index = int.Parse(tokens[1]);
                    string symbols = tokens[2];

                    inputLine = inputLine.Insert(index, symbols);

                    break;
                case "Delete":
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    inputLine = inputLine.Remove(startIndex, endIndex - startIndex + 1);

                    break;
            }

            commands = Console.ReadLine();
        }
        Console.WriteLine(inputLine);
    }
}