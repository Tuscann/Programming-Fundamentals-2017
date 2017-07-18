using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> digitsList = new List<int>();
        List<string> commands = new List<string>();
        List<string> digitsAndCommands = new List<string>();

        string input = Console.ReadLine();

        while (input != "stop")
        {
            digitsAndCommands.Add(input);
            input = Console.ReadLine();
        }

        SeparatingMethod(digitsList, commands, digitsAndCommands);

        digitsList.Reverse();
        int lastOne = 0;

        Solution(digitsList, commands, lastOne);
    }

    static void SeparatingMethod(List<int> digitsList, List<string> commands, List<string> digitsAndCommands)
    {
        for (int cycle = 0; cycle < digitsAndCommands.Count; cycle++)
        {
            int tryToParseString = 0;
            bool lamp = int.TryParse(digitsAndCommands[cycle], out tryToParseString);
            if (lamp)
            {
                digitsList.Add(tryToParseString);
            }
            else
            {
                commands.Add(digitsAndCommands[cycle]);
            }
        }
    }

    static void Solution(List<int> digitsList, List<string> commands, int lastOne)
    {
        for (int bangCycle = 0; bangCycle < int.MaxValue; bangCycle++)
        {
            int averageValue = 0;
            if (digitsList.Sum() != 0 && digitsList.Count != 0)
            {
                averageValue = digitsList.Sum() / digitsList.Count;
            }

            if (digitsList.Count == 0 && digitsList.Count < commands.Count)
            {
                Console.WriteLine("nobody left to shoot! last one was {0}", lastOne);
                break;
            }
            if (digitsList.Count == 0 && commands.Count == 0)
            {
                Console.WriteLine("you shot them all. last one was {0}", lastOne);
                break;
            }
            if (commands.Count == 0 && digitsList.Count > 0)
            {
                Console.WriteLine("survivors: " + string.Join(" ", digitsList));
                break;
            }
            else
            {
                for (int firstSmallerDigit = 0; firstSmallerDigit < digitsList.Count; firstSmallerDigit++)
                {
                    if (digitsList[firstSmallerDigit] <= averageValue)
                    {
                        lastOne = digitsList[firstSmallerDigit];
                        Console.WriteLine("shot {0}", digitsList[firstSmallerDigit]);
                        digitsList.RemoveAt(firstSmallerDigit);
                        commands.RemoveAt(0);
                        break;
                    }
                }

                for (int decrement = 0; decrement < digitsList.Count; decrement++)
                {
                    digitsList[decrement]--;
                }
                bangCycle--;
            }
        }
    }
}