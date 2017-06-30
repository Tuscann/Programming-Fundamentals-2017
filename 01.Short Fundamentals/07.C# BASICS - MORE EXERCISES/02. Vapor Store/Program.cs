using System;
class Program
{
    static void Main()
    {
        decimal currentBalance = decimal.Parse(Console.ReadLine());

        decimal sum = currentBalance;
        decimal price = 0;

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "OutFall 4")
                price = (decimal)39.99;
            else if (command == "CS: OG")
            {
                price = (decimal)15.99;
            }
            else if (command == "Zplinter Zell")
            {
                price = (decimal)19.99;
            }
            else if (command == "Honored 2")
            {
                price = (decimal)59.99;
            }
            else if (command == "RoverWatch")
            {
                price = (decimal)29.99;
            }
            else if (command == "RoverWatch Origins Edition")
            {
                price = (decimal)39.99;
            }
            else if (command == "Game Time")
            {
                Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", sum - currentBalance, currentBalance);
                break;
            }
            else
            {
                Console.WriteLine("Not Found");
                continue;
            }
            currentBalance -= price;
           
            if (currentBalance < 0)
            {
                Console.WriteLine("Too Expensive");
                currentBalance += price;
            }
            else if (currentBalance >= 0)
            {
                Console.WriteLine("Bought {0}", command);
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
        }
    }
}