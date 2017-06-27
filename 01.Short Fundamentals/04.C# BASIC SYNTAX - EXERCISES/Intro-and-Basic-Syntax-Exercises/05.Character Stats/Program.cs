using System;
class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        int current_health = int.Parse(Console.ReadLine());
        int maximum_health = int.Parse(Console.ReadLine());
        int current_energy = int.Parse(Console.ReadLine());
        int maxium_energy = int.Parse(Console.ReadLine());

        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Health: |{0}{1}|", new string('|', current_health), new string('.', maximum_health - current_health));
        Console.WriteLine("Energy: |{0}{1}|", new string('|', current_energy), new string('.', maxium_energy - current_energy));
    }
}
