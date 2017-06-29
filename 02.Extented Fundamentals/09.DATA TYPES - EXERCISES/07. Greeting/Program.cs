using System;
class Program
{
    static void Main()
    {
        string first = Console.ReadLine();
        string secound = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hello, {first} {secound}.\nYou are {age} years old.");
    }
}