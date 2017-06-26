using System;
class Program
{
    static void Main()
    {
        string person = Console.ReadLine();
        string drink;

        if (person == "Athlete")
        {
            drink = "Water";
        }
        else if (person == "Businessman" || person == "Businesswoman")
        {
            drink = "Coffee";
        }
        else if (person == "SoftUni Student")
        {
            drink = "Beer";
        }
        else
        {
            drink = "Tea";
        }
        Console.WriteLine(drink);
    }
}