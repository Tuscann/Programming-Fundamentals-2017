using System;
class P01_Passed
{
    static void Main() //100/100
    {
        double grade = double.Parse(Console.ReadLine());
        if (grade >= 3)
        {
            Console.WriteLine("Passed!");
        }
    }
}