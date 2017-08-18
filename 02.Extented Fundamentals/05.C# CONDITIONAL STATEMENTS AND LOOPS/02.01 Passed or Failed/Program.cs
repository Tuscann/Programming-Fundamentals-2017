using System;
class P02_PassedOrFailed
{
    static void Main() //100/100
    {
        double grade = double.Parse(Console.ReadLine());
        Console.WriteLine(grade >= 3 ? "Passed!" : "Failed!");
    }
}