using System;
class Program
{
    static void Main()
    {
        int countPersons = int.Parse(Console.ReadLine());
        int capacistyElevator = int.Parse(Console.ReadLine());

        int courses = countPersons / capacistyElevator;
        int remainder = countPersons % capacistyElevator;

        if (remainder == 0)
        {
            Console.WriteLine(courses);
        }
        else if (remainder != 0)
        {
            Console.WriteLine(courses + 1); ;
        }
    }
}