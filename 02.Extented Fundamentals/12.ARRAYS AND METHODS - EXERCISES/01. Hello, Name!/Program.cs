using System;
class Program
{
    static void Main() // 100/100
    {
        string name = Console.ReadLine();
        PrintName(name);
    }
    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}