using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> lineOfDigits = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> lineOfCommands = Console.ReadLine().Split().Select(int.Parse).ToList();

        int takeThisMuchDigits = lineOfCommands[0];
        int removeThisMuchDigits = lineOfCommands[1];
        int checkThisOut = lineOfCommands[2];

        lineOfDigits.Take(takeThisMuchDigits);
        foreach (var VARIABLE in lineOfDigits)
        {
            Console.WriteLine(VARIABLE);
        }
        Console.WriteLine();


        lineOfDigits.RemoveRange(0, removeThisMuchDigits);
        foreach (var VARIABLE in lineOfDigits)
        {
            Console.WriteLine(VARIABLE);
        }

        if (lineOfDigits.Contains(checkThisOut))
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }
    }
}
