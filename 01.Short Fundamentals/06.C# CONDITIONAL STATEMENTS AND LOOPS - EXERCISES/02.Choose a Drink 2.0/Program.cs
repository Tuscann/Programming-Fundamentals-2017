using System;
class Program
{
    static void Main()
    {
        string person = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        string drink;
        double price = 0;

        if (person == "Athlete")
        {
            drink = "Water";
            price = 0.7;
        }
        else if (person == "Businessman" || person == "Businesswoman")
        {
            drink = "Coffee";
            price = 1.0;
        }
        else if (person == "SoftUni Student")
        {
            drink = "Beer";
            price = 1.7;
        }
        else
        {
            drink = "Tea";
            price = 1.2;
        }
        Console.WriteLine("The {0} has to pay {1:f2}.",person,quantity*price);
    }
}