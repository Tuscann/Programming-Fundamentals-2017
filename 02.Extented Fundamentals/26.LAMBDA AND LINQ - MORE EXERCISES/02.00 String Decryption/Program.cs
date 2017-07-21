using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> givenArray = Console.ReadLine().Split().Select(int.Parse).ToList();

        int elemtsToSkip = elements[0];
        int elemtsToTake = elements[1];

        List<int> result = givenArray.Where(x => x >= 65 && x <= 90).ToList();

        result = result.Skip(elemtsToSkip).Take(elemtsToTake).ToList();

        Console.WriteLine("{0}", string.Join("", result.Select(x => (char)x)));
    }
}