using System;
class P01_X
{
    static void Main() // 100/100
    {
        int xSize = int.Parse(Console.ReadLine());

        int spacesAfterX = xSize - 2;
        for (int i = 0; i < xSize / 2; i++, spacesAfterX -= 2)
        {
            Console.WriteLine($"{new string(' ', i)}x{new string(' ', spacesAfterX)}x");
        }
        Console.WriteLine($"{new string(' ', xSize / 2)}x");
        spacesAfterX = 1;
        for (int i = xSize / 2; i > 0; i--, spacesAfterX += 2)
        {
            Console.WriteLine($"{new string(' ', i - 1)}x{new string(' ', spacesAfterX)}x");
        }
    }
}