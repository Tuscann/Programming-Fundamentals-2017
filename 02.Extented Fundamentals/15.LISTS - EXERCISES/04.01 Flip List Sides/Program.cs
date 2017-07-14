using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> givenNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> rotatedNumbers = new List<int>(givenNumbers.Count);

        rotatedNumbers.Add(givenNumbers[0]);

        for (int cycle = 1; cycle < givenNumbers.Count - 1; cycle++)
        {
            rotatedNumbers.Add(givenNumbers[givenNumbers.Count - 1 - cycle]);
        }
        rotatedNumbers.Add(givenNumbers[givenNumbers.Count - 1]);

        Console.WriteLine(string.Join(" ", rotatedNumbers));
    }
}
