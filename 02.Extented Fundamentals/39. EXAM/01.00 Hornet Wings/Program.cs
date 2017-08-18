using System;
class Program
{
    static void Main() // 100/100
    {
        long wingFlaps = long.Parse(Console.ReadLine());
        double move = double.Parse(Console.ReadLine());
        int endurance = int.Parse(Console.ReadLine());
        
        double print = wingFlaps / 1000 * move;

        long x = wingFlaps / 100 + wingFlaps / endurance * 5;

        Console.WriteLine("{0:f2} m.", print);
        Console.WriteLine("{0} s.", x);
    }
}