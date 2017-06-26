using System;
class Program
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());
        if (grade < 3.00)
        {
            Console.WriteLine("Failed!");
        }
        else if (grade >= 3.00 || grade <= 6.00)
        {
            Console.WriteLine("Passed!");
        }
    }
}

