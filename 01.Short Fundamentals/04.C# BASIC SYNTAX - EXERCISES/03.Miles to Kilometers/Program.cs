using System;
class Program
{
    static void Main()
    {
        var name = Console.ReadLine();
        int volume = int.Parse(Console.ReadLine());
        int energy = int.Parse(Console.ReadLine());
        int sugar = int.Parse(Console.ReadLine());

        double energy_need = (double)energy * volume/100;
        double sugar_need = (double)sugar * volume / 100;

        Console.WriteLine("{0}ml {1}:", volume, name);
        Console.WriteLine("{0}kcal, {1}g sugars", energy_need, sugar_need);
    }
}

