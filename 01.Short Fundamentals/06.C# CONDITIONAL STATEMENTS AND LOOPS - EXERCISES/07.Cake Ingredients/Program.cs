using System;
class Program
{
    static void Main()
    {
        int counter = 0;
        while (true)
        {
            string CommandBehavior = Console.ReadLine();

            if (CommandBehavior == "Bake!")
            {
                break; ;
            }
            Console.WriteLine("Adding ingredient {0}.", CommandBehavior);
            counter++;
        }
        Console.WriteLine("Preparing cake with {0} ingredients.", counter);

    }
}