using System;
class P02_VaporStore
{
    static void Main() // 100/100
    {
        double moneyLeft = double.Parse(Console.ReadLine());
        double moneySpent = 0;

        while (moneyLeft > 0)
        {
            double gamePrice = 0;
            string gameBought = Console.ReadLine();
            switch (gameBought)
            {
                case "CS: OG":
                    gamePrice = 15.99;
                    break;
                case "Zplinter Zell":
                    gamePrice = 19.99;
                    break;
                case "Honored 2":
                    gamePrice = 59.99;
                    break;
                case "RoverWatch":
                    gamePrice = 29.99;
                    break;
                case "OutFall 4":
                case "RoverWatch Origins Edition":
                    gamePrice = 39.99;
                    break;
                case "Game Time":
                    Console.WriteLine($"Total spent: ${moneySpent:F2}. Remaining: ${moneyLeft:F2}");
                    return;
                default:
                    Console.WriteLine("Not Found");
                    continue;
            }

            if (moneyLeft >= gamePrice)
            {
                Console.WriteLine($"Bought {gameBought}");
                moneyLeft -= gamePrice;
                moneySpent += gamePrice;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
        }

        Console.WriteLine("Out of money!");
    }
}