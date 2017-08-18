using System;
class Program
{
    static void Main() // 100/100
    {
        decimal cashMoney = decimal.Parse(Console.ReadLine());
        decimal numberOfGuests = decimal.Parse(Console.ReadLine());
        decimal bananasPriceForOneUnit = decimal.Parse(Console.ReadLine());
        decimal eggsPricePerOneUnit = decimal.Parse(Console.ReadLine());
        decimal berriesPricePerKilo = decimal.Parse(Console.ReadLine());

        decimal setsOfPortions = Math.Ceiling(numberOfGuests / 6);

        decimal neededMoney = setsOfPortions * (2 * bananasPriceForOneUnit) + setsOfPortions * (4 * eggsPricePerOneUnit) + setsOfPortions * ((decimal)0.2 * berriesPricePerKilo);

        if (neededMoney <= cashMoney)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:f2}lv.");
        }
        else
        {
            decimal totalMoney = neededMoney - cashMoney;
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {totalMoney:f2}lv more.");
        }
    }
}