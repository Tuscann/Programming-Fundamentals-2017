using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string toReverse = Console.ReadLine();
        var reversedCharArray = toReverse.ToCharArray().Reverse();
        Console.WriteLine(string.Join("", reversedCharArray));
    }
}
