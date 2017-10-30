using System;
public class Program   // 100/100
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            long totalLenght = long.Parse(Console.ReadLine());
            decimal totalWidthOfTheBody = decimal.Parse(Console.ReadLine());
            long lengthOfOneWing = long.Parse(Console.ReadLine());
            decimal totalYears = (decimal)Math.Pow(totalLenght, 2) * (totalWidthOfTheBody + 2 * lengthOfOneWing);
            Console.WriteLine($"{totalYears}");
        }
    }
}
