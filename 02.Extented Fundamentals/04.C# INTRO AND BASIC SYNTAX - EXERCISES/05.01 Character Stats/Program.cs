using System;
public class P05_CharacterStats
{
    public static void Main() // 100/100
    {
        string characterName = Console.ReadLine();
        int characterHealth = int.Parse(Console.ReadLine());
        int maxHealth = int.Parse(Console.ReadLine());
        int characterEnergy = int.Parse(Console.ReadLine());
        int maxEnergy = int.Parse(Console.ReadLine());

        string healthBar = buildStatBar(characterHealth, maxHealth);
        string energyBar = buildStatBar(characterEnergy, maxEnergy);
        Console.WriteLine($"Name: {characterName}");
        Console.WriteLine($"Health: {healthBar}");
        Console.WriteLine($"Energy: {energyBar}");
    }

    public static string buildStatBar(int statValue, int barMaxValue)
    {
        string statBar = "|" + new string('|', statValue) + new string('.', barMaxValue - statValue) + "|";
        return statBar;
    }
}
