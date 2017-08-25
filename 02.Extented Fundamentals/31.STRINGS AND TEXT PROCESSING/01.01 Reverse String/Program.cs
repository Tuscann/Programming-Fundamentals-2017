using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        string output2 = new string(input.Reverse().ToArray());

        Console.WriteLine(output2);
    }
}