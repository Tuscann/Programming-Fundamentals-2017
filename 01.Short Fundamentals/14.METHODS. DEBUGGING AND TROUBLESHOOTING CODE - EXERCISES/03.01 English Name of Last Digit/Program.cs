using System;

class Program
{
    static void Main()
    {
        string[] a = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string n = Console.ReadLine();
        Console.WriteLine(a[int.Parse(n[n.Length - 1].ToString())]);
    }
}