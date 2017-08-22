using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Worm Ipsum")
            {
                break;
            }
            int count = input.Count(f => f == '.');



            if (input[0].ToString() == input[0].ToString().ToUpper() && count == 1 && input[input.Length - 1].ToString() == ".")
            {
                var area = input.Split().ToArray();
                foreach (var word in area)
                {
                    
                }

            }


        }
    }
}

