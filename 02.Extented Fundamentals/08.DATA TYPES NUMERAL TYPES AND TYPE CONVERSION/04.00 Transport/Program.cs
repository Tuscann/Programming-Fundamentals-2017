using System;
class Program
{
    static void Main()
    {
        int persons = int.Parse(Console.ReadLine());
        int cources = persons / 24;

        if (persons % 24 != 0)
        {
            cources++;
        }
        Console.WriteLine(cources);
    }
}