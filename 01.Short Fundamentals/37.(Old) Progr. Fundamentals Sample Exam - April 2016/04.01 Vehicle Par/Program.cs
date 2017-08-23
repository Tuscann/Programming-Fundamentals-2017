using System;
using System.Collections.Generic;
using System.Linq;
class VehicleParkSold
{
    static void Main()
    {
        int count = 0;
        List<string> list = Console.ReadLine().Split(' ').ToList();

        string customer = Console.ReadLine().ToLower();
        while (customer != "end of customers!")
        {
            string[] customerSplit = customer.Split(' ');
            char car = customerSplit[0][0];
            int seats = int.Parse(customerSplit[2]);
            
            if (list.Contains(car + seats.ToString()))
            {
                Console.WriteLine("Yes, sold for {0}$", car * seats);
                list.Remove(car + seats.ToString());
                count++;
            }
            else
            {
                Console.WriteLine("No");
            }

            customer = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Vehicles left: " + string.Join(", ", list));
        Console.WriteLine("Vehicles sold: {0}", count);
    }
}