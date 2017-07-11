using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split().ToList();
        long altitude = long.Parse(input[0]);
        List<string> commands = getCommands(input);

        for (int i = 0; i < commands.Count; i++)
        {
            string[] comm = commands[i].Split();
            string upOrDown = comm[0];
            long Count = long.Parse(comm[1]);
            if (upOrDown.Equals("up"))
            {
                altitude += Count;
            }
            else
            {
                altitude -= Count;
            }

            if (altitude <= 0)
            {
                Console.WriteLine("crashed");
                break;
            }
        }

        if (altitude > 0)
        {
            Console.WriteLine("got through safely. current altitude: {0}m", altitude);
        }
    }

    private static List<string> getCommands(List<string> input)
    {
        List<string> a = new List<string>();
        for (int i = 1; i < input.Count; i += 2)
        {
            a.Add(input[i] + " " + input[i + 1]);
        }
        return a;
    }
}
