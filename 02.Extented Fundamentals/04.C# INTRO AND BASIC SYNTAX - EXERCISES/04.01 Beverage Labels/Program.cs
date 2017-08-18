using System;
public class P04_BeverageLabels
{
    public static void Main() // 100/100
    {
        string product = Console.ReadLine();
        int volume = int.Parse(Console.ReadLine());
        int energyPer100ml = int.Parse(Console.ReadLine());
        int sugarPer100ml = int.Parse(Console.ReadLine());

        double totalEnergy = energyPer100ml / 100.0 * volume;
        double totalSugar = sugarPer100ml * volume / 100.0;

        Console.WriteLine("{0}ml {1}:", volume, product);
        Console.WriteLine("{0}kcal, {1}g sugars", totalEnergy, totalSugar);
    }
}