using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._00_Most_Valued_Customer
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, double> products = new Dictionary<string, double>();



            while (true)
            {
                string x = Console.ReadLine();
                if (x == "Shop is open")
                {
                    break;
                }
                List<string> current = x.Split().ToList();

                string productName = current[0];
                double productPrice = double.Parse(current[1]);

                if (!products.ContainsKey(productName))
                {
                    products[productName] = 0;
                }
                products[productName] = productPrice;
            }

            Dictionary<string, double> dict = new Dictionary<string, double>();

            while (true)
            {
                string xs = Console.ReadLine();
                if (xs == "Print")
                {
                    break;
                }
                if (xs == "Discount")
                {
                    Console.WriteLine(1);
                }
                else
                {
                    List<string> curent = xs.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    string name = curent[0];
                    string[] type = curent[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                    if (!dict.ContainsKey(name))
                    {
                        dict[name] = 0;
                    }
                    foreach (string searchedProduct in type)
                    {
                        foreach (KeyValuePair<string, double> product in products)
                        {
                            if (searchedProduct == product.Key)
                            {
                                dict[name] = product.Value;
                                break;
                            }
                        }
                    }
                    dict = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                    KeyValuePair<string, double> contactToPrint = dict.First();

                    Console.WriteLine(contactToPrint.Key);
                }
               
            }
               








        }
    }
}
