using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Vapor_Store_02
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            decimal leftMoney = money;
            bool lamp = false;

            while (game != "Game Time")
            {
                if (game == "OutFall 4")
                {
                    if (money < 39.98m)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought OutFall 4");
                        money -= 39.99m;
                    }
                }
                else if (game == "CS: OG")
                {
                    if (money < 15.98m)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought CS: OG");
                        money -= 15.99m;
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    if (money < 19.98m)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                        money -= 19.99m;
                    }
                }
                else if (game == "Honored 2")
                {
                    if (money < 59.98m)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought Honored 2");
                        money -= 59.99m;
                    }
                }
                else if (game == "RoverWatch")
                {
                    if (money < 29.98m)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought RoverWatch");
                        money -= 29.99m;
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (money < 39.98m)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        money -= 39.99m;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (money <= 0)
                {
                    Console.WriteLine("Out of money!");
                    lamp = true;
                    break;
                }

                game = Console.ReadLine();

            }

            if (lamp == false || game == "Game Time")
            {
                leftMoney -= money;
                Console.WriteLine("Total spent: ${0}. Remaining: ${1}", leftMoney, money);
            }
        }
    }
}