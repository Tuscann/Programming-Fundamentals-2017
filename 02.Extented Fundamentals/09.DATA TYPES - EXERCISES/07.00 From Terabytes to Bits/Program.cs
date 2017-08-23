using System;

public class Numbers
{
    public static void Main() // 100/100
    {
        decimal tb = decimal.Parse(Console.ReadLine());
        decimal tbToBit = tb * 1024 * 1024 * 1024 * 1024 * 8;
        Console.WriteLine("{0:f0}", tbToBit);
    }
}