using System;
class Program
{
    static void Main() // 100/100
    {
        decimal money = decimal.Parse(Console.ReadLine());
        int guests = int.Parse(Console.ReadLine());
        decimal bananaPrice = decimal.Parse(Console.ReadLine());
        decimal eggPrice = decimal.Parse(Console.ReadLine());
        decimal berryPrice = decimal.Parse(Console.ReadLine());

        int portions = 0;
        if (guests % 6 > 0)
        {
            portions = guests / 6 + 1;
        }
        else if (guests % 6 == 0)
        {
            portions = guests / 6;
        }

        decimal totalDamage = bananaPrice * portions * 2 + eggPrice * portions * 4 + berryPrice * portions * 0.2m;

        if (money >= totalDamage)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {totalDamage:f2}lv.");
        }
        else
        {
            decimal neededMoney = totalDamage - money;
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:f2}lv more.");
        }
    }
}