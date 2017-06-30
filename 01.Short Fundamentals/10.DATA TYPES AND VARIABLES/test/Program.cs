using System;
class Program
{
    static void Main()
    {
        var fruit = Console.ReadLine();
        var size = Console.ReadLine();
        var quantity = int.Parse(Console.ReadLine());
        var total = 0.0;

        switch (fruit)
        {
            case "Watermelon":
                {
                    if (size == "small")
                    {
                        total = quantity * 2 * 56;
                    }
                    else if(size == "big")
                    {
                        total = quantity * (5 * 28.70);
                    }
                    break;
                }
            case "Mango":
                {
                    if (size == "small")
                    {
                        total = quantity * (2 * 36.66);
                    }
                    else
                    {
                        total = quantity * (5 * 19.60);
                    }
                    break;
                }
            case "Pineapple":
                {
                    if (size == "small")
                    {
                        total = quantity * (2 * 42.10);
                    }
                    else
                    {
                        total = quantity * (5 * 24.80);
                    }
                    break;
                }
            case "Raspberry":
                {
                    if (size == "small")
                    {
                        total = quantity * (2 * 20);
                    }
                    else
                    {
                        total = quantity * (5 * 15.20);
                    }
                    break;
                }
        }
        if (total > 1000)
        {
            total = total - (total * 0.5);

        }
        else if (400 >= total && total <= 1000)
        {
            total = total - (total * 0.15);
        }
        Console.WriteLine($"{ total:f2} lv.");
    }
}
