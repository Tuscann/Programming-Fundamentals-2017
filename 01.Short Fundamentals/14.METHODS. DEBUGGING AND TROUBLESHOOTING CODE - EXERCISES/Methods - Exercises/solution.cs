using System;
class Program
{
    static void printName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
    static void Main()
    {
        string name = Console.ReadLine();
        printName(name);
    }
}
