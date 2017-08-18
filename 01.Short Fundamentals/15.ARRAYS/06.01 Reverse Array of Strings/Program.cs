using System;
using System.Linq;
class P06_ReverseArrayOfStrings
{
    static void Main() // 100/100
    {
        string[] inputStrArrReverced = Console.ReadLine()
            .Split(' ')
            .ToArray()
            .Reverse()
            .ToArray();

        Console.WriteLine(string.Join(" ", inputStrArrReverced));
    }
}