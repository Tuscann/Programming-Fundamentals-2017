using System;
class Program
{
    static void printName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
    static void Main()  // 100/100
    {
        string name = Console.ReadLine();
        printName(name);
    }
}
