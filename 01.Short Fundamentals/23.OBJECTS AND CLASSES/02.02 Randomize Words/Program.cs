using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] lineOfWords = Console.ReadLine().Split();

        var randomNumGen = new Random();

        string[] randomLineOfWords = lineOfWords.OrderBy(x => randomNumGen.Next()).ToArray();

        foreach (var word in randomLineOfWords)
        {
            Console.WriteLine(word);
        }
    }
}
