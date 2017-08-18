using System;
class P07_CakeIngredients
{
    static void Main()  // 100/100
    {
        string ingredient = Console.ReadLine();
        int ingredientsCount = 0;

        while (ingredient != "Bake!")
        {
            ingredientsCount++;
            Console.WriteLine($"Adding ingredient {ingredient}.");
            ingredient = Console.ReadLine();
        }

        Console.WriteLine($"Preparing cake with {ingredientsCount} ingredients.");
    }
}