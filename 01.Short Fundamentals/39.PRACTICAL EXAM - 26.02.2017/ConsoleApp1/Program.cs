using System;
class Program
{
    static void Main() //100/100
    {
        int wingFlaps = int.Parse(Console.ReadLine());
        double distancePer1000 = double.Parse(Console.ReadLine());
        int endurance = int.Parse(Console.ReadLine());

        double distance = wingFlaps / 1000.0 * distancePer1000;
        Console.WriteLine("{0:f2} m.", distance);

        long sum = wingFlaps / endurance * 5L + wingFlaps / 100;
        Console.WriteLine("{0:f0} s.", sum);
    }
}