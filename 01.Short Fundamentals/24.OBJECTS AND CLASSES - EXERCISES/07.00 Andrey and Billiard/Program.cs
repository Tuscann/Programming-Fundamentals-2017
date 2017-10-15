using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Andrey_and_billiard  // 100/100
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, double> ShopList { get; set; }
        public double Bill { get; set; }

    }
    class Program
    {
        static void Main()
        {

            Dictionary<string, double> menu = new Dictionary<string, double>();
            int numberOfItems = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfItems; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                if (!menu.ContainsKey(input[0]))
                {
                    menu.Add(input[0], double.Parse(input[1]));
                }
                else
                {
                    menu[input[0]] = double.Parse(input[1]);
                }

            }
            List<Customer> allCustomers = new List<Customer>();
            while (true)
            {
                string info = Console.ReadLine();
                if (info == "end of clients")
                {
                    break;
                }
                string[] clientInfo = info.Split('-', ',');
                string customerName = clientInfo[0];
                string product = clientInfo[1];
                double quantity = double.Parse(clientInfo[2]);

                if (!menu.ContainsKey(product)) { continue; }

                Customer client = new Customer();
                client.ShopList = new Dictionary<string, double>();
                client.Name = clientInfo[0];
                client.ShopList.Add(product, quantity);

                if (allCustomers.Any(c => c.Name == customerName))
                {
                    Customer existingCustomer = allCustomers.First(c => c.Name == customerName);
                    if (existingCustomer.ShopList.ContainsKey(product))
                    {
                        existingCustomer.ShopList[product] += quantity;
                    }
                    else
                    {
                        existingCustomer.ShopList[product] = quantity;
                    }
                }
                else
                {
                    allCustomers.Add(client);
                }
            }
/// Това го правим само за да направим bill-a:
            foreach (var customer in allCustomers)
            {
                foreach (var item in customer.ShopList)
                {
                  
                    foreach (var product in menu)
                    {
                        if (item.Key == product.Key) { customer.Bill += item.Value * product.Value; }
                    }
                }
            }
            var ordered = allCustomers
                            .OrderBy(x => x.Name)
                            .ThenBy(x => x.Bill)
                            .ToList();
            foreach (var customer in ordered)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, double> item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine("Bill: {0:f2}", customer.Bill);
              
            }
            Console.WriteLine("Total bill: {0:F2}", allCustomers.Sum(c => c.Bill));
        }
    }
}