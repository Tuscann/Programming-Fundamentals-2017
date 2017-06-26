using System;
class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int volume = int.Parse(Console.ReadLine());
        int energy = int.Parse(Console.ReadLine());
        int sugar = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}ml {1}:", volume,name);
        Console.WriteLine("{0}kcal, {1}g sugars",);
    }
}

