using System;
class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());
        double moneySpent = 0;
        for (int i = 0; i < n; i++)
        {
            String s = Console.ReadLine();

            double price = double.Parse(Console.ReadLine());
            double quantity = double.Parse(Console.ReadLine());

            moneySpent += price * quantity;
            if (quantity <= 2)
            {
                Console.WriteLine($"Adding {quantity} {s}s to cart.");
            }
            else
            {
                Console.WriteLine($"Adding {quantity} {s}s to cart.");
            }
        }
        if (moneySpent <= budget)
        {
            Console.WriteLine($"Subtotal: ${moneySpent:F2}");
            Console.WriteLine($"Money left: ${Math.Abs(budget - moneySpent):F2}");
        }
        else
        {
            Console.WriteLine($"Subtotal: ${Math.Abs(moneySpent):F2}");
            Console.WriteLine($"Not enough. We need ${moneySpent - budget:F2} more.");
        }
    }
}