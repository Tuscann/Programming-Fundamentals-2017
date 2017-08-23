using System;
class BallisticsTraining_2
{
    static void Main() // 100/100
    {
        string targets = Console.ReadLine();
        string commands = Console.ReadLine();

        string[] splitTargets = targets.Split(' ');
        string[] splitCommands = commands.Split(' ');

        string resultOfShot = GetResult(splitCommands, splitTargets);
        Console.WriteLine(resultOfShot);
    }

    static string GetResult(string[] splitCommands, string[] splitTargets)
    {
        string resultOfShot;
        long x = 0, y = 0;
        for (int i = 0; i < splitCommands.Length - 1; i += 2)
        {
            string direction = splitCommands[i];
            long number = long.Parse(splitCommands[i + 1]);

            if (direction == "up")
            {
                y += number;
            }
            else if (direction == "down")
            {
                y -= number;
            }
            else if (direction == "left")
            {
                x -= number;
            }
            else if (direction == "right")
            {
                x += number;
            }
        }

        resultOfShot = $"firing at [{x}, {y}]\n";
        resultOfShot += CheckIfShot(x, y, splitTargets);
        return resultOfShot;
    }

    static string CheckIfShot(long x, long y, string[] splitTargets)
    {
        string result;
        long target_X = long.Parse(splitTargets[0]);
        long target_Y = long.Parse(splitTargets[1]);

        if (target_X == x && target_Y == y)
        {
            result = "got 'em!";
        }
        else
        {
            result = "better luck next time...";
        }
        return result;
    }
}