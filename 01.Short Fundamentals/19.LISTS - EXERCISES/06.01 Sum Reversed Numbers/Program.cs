using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> lineOfStrings = Console.ReadLine().Split().ToList();
        List<int> solution = new List<int>(lineOfStrings.Count);

        for (int cycle = 0; cycle < lineOfStrings.Count; cycle++)
        {
            string temp = lineOfStrings[cycle];
            char[] makeAnArray = temp.ToCharArray();
            Array.Reverse(makeAnArray);
            string stringToBeInteger = new string(makeAnArray);
            int toInteger = int.Parse(stringToBeInteger);
            solution.Add(toInteger);
        }
        Console.WriteLine(solution.Sum());
    }
}
