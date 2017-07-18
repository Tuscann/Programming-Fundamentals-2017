using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<double> list = new List<double>();

        double last = 0;
        bool isss = true;

        while (true)
        {
            string curent = Console.ReadLine();
            if (curent == "stop")
            {
                break;
            }
            int number = 0;

            bool isInteger = int.TryParse(curent, out number);

            if (isInteger)
            {
                list.Insert(0, number);
            }
            if (curent == "bang")
            {
                if (list.Count == 0)  //if is 0 count and wanth to shoot again
                {
                    Console.WriteLine("nobody left to shoot! last one was {0}", last);
                    isss = false;
                    break;
                }
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] <= list.Average())
                    {
                        Console.WriteLine("shot {0}", list[i]);
                        last = list[i];
                        list.Remove(list[i]);
                        break;
                    }
                }
                for (int j = 0; j < list.Count; j++)
                {
                    list[j]--;
                }
            }
        }
        if (list.Count == 0)
        {
            if (isss)
            {
                Console.WriteLine("you shot them all. last one was {0}", last);
            }
        }
        if (list.Count != 0)
        {
            Console.WriteLine("survivors: {0}", string.Join(" ", list));
        }
    }
}