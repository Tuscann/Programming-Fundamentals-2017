using System;
class Program
{
    static void Main() // 100/100
    {
        string person = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        
        double price = 0;

        if (person == "Athlete")
        {
            price = 0.7;
        }
        else if (person == "Businessman" || person == "Businesswoman")
        {
            price = 1.0;
        }
        else if (person == "SoftUni Student")
        {
            price = 1.7;
        }
        else
        {
            price = 1.2;
        }
        Console.WriteLine("The {0} has to pay {1:f2}.", person, quantity * price);
    }
}