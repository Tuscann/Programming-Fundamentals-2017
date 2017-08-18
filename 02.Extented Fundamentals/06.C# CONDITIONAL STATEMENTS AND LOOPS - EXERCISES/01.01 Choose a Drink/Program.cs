using System;
class P01_ChooseADrink
{
    static void Main() // 100/100
    {
        string profession = Console.ReadLine();
        string drink;
        switch (profession)
        {
            case "Athlete":
                drink = "Water";
                break;
            case "Businessman":
            case "Businesswoman":
                drink = "Coffee";
                break;
            case "SoftUni Student":
                drink = "Beer";
                break;
            default:
                drink = "Tea";
                break;
        }
        Console.WriteLine(drink);
    }
}