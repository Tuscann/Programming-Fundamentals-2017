using System;
class Program
{
    static void Main()
    {
        int groupSize = int.Parse(Console.ReadLine());
        string package = Console.ReadLine();
        decimal price = 0;
        decimal price2 = 0;
        decimal discount = 0;
        string hall = "";

        if (package == "Normal")
        {
            discount = (decimal)0.05;
            price2 = 500;

        }
        else if (package == "Gold")
        {
            discount = (decimal)0.1;
            price2 = 750;

        }
        else if (package == "Platinum")
        {
            discount = (decimal)0.15;
            price2 = 1000;

        }
        if (groupSize <= 50)
        {
            price = 2500;
            hall = "Small Hall";
        }
        else if (groupSize >= 51 && groupSize <= 100)
        {
            price = 5000;
            hall = "Terrace";
        }
        else if (groupSize >= 101 && groupSize <= 120)
        {
            price = 7500;
            hall = "Great Hall";
        }


        if (groupSize > 120)
        {
            Console.WriteLine("We do not have an appropriate hall.");
        }
        else
        {
            decimal sum = (price + price2) * (1 - discount);
            decimal pricePerPerson = sum / groupSize;

            Console.WriteLine("We can offer you the {0}", hall);
            Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
        }
    }
}