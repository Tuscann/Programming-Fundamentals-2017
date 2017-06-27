using System;
class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string employeeId = Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());

        Console.WriteLine("Name: {0}",name);
        Console.WriteLine("Age: {0}",age);
        Console.WriteLine("Employee ID: {0}",employeeId.PadLeft(8,'0'));
        Console.WriteLine("Salary: {0:f2}",salary);
    }
}