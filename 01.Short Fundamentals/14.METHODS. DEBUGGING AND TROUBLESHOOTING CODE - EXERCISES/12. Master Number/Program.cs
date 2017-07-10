using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            bool isEven = false;


            for (int i = 1; i <= number; i++)
            {
                string count = i.ToString();

                if (count.Length % 2 == 0)
                {
                     
                }
                else
                {
                    
                }


                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
