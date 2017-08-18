using System;
class P07_TrainingHallEquipment
{
    static void Main() // 100/100
    {
        double budget = double.Parse(Console.ReadLine());
        int itemsCount = int.Parse(Console.ReadLine());
        double subtotal = 0;
        for (int i = 0; i < itemsCount; i++)
        {
            string productName = Console.ReadLine();
            double productPrice = double.Parse(Console.ReadLine());
            int productCount = int.Parse(Console.ReadLine());

            productName += productCount > 1 ? "s" : "";

            Console.WriteLine($"Adding {productCount} {productName} to cart.");
            subtotal += (productPrice * productCount);
        }

        Console.WriteLine($"Subtotal: ${subtotal:F2}");

        Console.WriteLine(
            budget >= subtotal ?
                $"Money left: ${budget - subtotal:F2}" :
                $"Not enough. We need ${subtotal - budget:F2} more."
        );
    }
}