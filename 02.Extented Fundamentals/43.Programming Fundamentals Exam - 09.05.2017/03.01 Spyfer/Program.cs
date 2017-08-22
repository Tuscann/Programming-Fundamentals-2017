using System;
using System.Collections.Generic;
using System.Linq;

public class Spyfer
{
    static List<int> givenSequenceFromIntegers;

    public static void Main() // 100/100
    {
        givenSequenceFromIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        givenSequenceFromIntegers = ChekTheNeighbursInTheGivenSequence();

        PrintGivenSequenceFromIntegers();
    }

    static List<int> ChekTheNeighbursInTheGivenSequence()
    {
        int current = 0;
        int left = 0;
        int right = 0;

        int standingNumbers = givenSequenceFromIntegers.Count;
        for (int index = 0; index < givenSequenceFromIntegers.Count; index++)
        {
            current = givenSequenceFromIntegers[index];
            if (index > 0 && index < givenSequenceFromIntegers.Count - 1 && standingNumbers > 1)
            {
                left = givenSequenceFromIntegers[index - 1];
                right = givenSequenceFromIntegers[index + 1];

                if (current == left + right)
                {
                    givenSequenceFromIntegers.RemoveAt(index + 1);
                    givenSequenceFromIntegers.RemoveAt(index - 1);
                    ChekTheNeighbursInTheGivenSequence();
                }
            }
            else if (index == 0 && standingNumbers > 1)
            {
                right = givenSequenceFromIntegers[index + 1];
                if (current == right)
                {
                    givenSequenceFromIntegers.RemoveAt(index + 1);
                    ChekTheNeighbursInTheGivenSequence();
                }
            }
            else if (index == givenSequenceFromIntegers.Count - 1 && standingNumbers > 1)
            {
                left = givenSequenceFromIntegers[index - 1];
                if (current == left)
                {
                    givenSequenceFromIntegers.RemoveAt(index - 1);
                    ChekTheNeighbursInTheGivenSequence();
                }
            }
        }
        return givenSequenceFromIntegers;
    }

    static void PrintGivenSequenceFromIntegers()
    {
        bool isFirst = true;
        for (int index = 0; index < givenSequenceFromIntegers.Count; index++)
        {
            if (isFirst)
            {
                Console.Write(givenSequenceFromIntegers[index]);
                isFirst = false;
                continue;
            }
            Console.Write($" {givenSequenceFromIntegers[index]}");
        }
        Console.WriteLine();
    }
}