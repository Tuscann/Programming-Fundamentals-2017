using System;
class Program
{
    static void Main()
    {
        int damegePesho = int.Parse(Console.ReadLine());
        int damegeGosho = int.Parse(Console.ReadLine());

        int healthPesho = 100;
        int healthGosho = 100;
        int counter = 1;

        while (true)
        {
            if (counter % 2 == 1)
            {
                healthGosho -= damegePesho;

                if (healthGosho <= 0)
                {
                    Console.WriteLine("Pesho won in {0}th round.", counter);
                    break;
                }
                Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", healthGosho);
            }
            else if (counter % 2 == 0)
            {
                healthPesho -= damegeGosho;

                if (healthPesho <= 0)
                {
                    Console.WriteLine("Gosho won in {0}th round.", counter);
                    break;
                }
                Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", healthPesho);
            }
            if (counter % 3 == 0)
            {
                healthGosho += 10;
                healthPesho += 10;
            }
            counter++;
        }
    }
}