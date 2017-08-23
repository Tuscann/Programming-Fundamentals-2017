using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] firePosition = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string[] commands = Console.ReadLine().Split(' ').ToArray();

        int x = 0, y = 0;

        for (int i = 0; i < commands.Length - 1; i += 2)
        {
            string command = commands[i];
            int number = int.Parse(commands[i + 1]);

            if (command == "right")
            {
                x += number;
            }
            else if (command == "left")
            {
                x -= number;
            }
            else if (command == "up")
            {
                y += number;
            }
            else if (command == "down")
            {
                y -= number;
            }
        }
        Console.WriteLine("firing at [{0}, {1}]", x, y);

        if (x == firePosition[0] && y == firePosition[1])
        {
            Console.WriteLine("got \'em!");
        }
        else
        {
            Console.WriteLine("better luck next time...");
        }
    }
}