using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int sum = Console.ReadLine().Split().Select(e => new String(e.Reverse().ToArray())).Sum(e => int.Parse(e));
        Console.WriteLine(sum);
    }
}