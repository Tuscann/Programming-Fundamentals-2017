using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        int sizeOfField = int.Parse(Console.ReadLine());
        var indexes = Console.ReadLine().Split().Select(int.Parse).ToList();
        while (true)
        {
            var curentRow = Console.ReadLine().Split().ToList();
            int ladybugIndex = int.Parse(curentRow[0]);
            string direction = curentRow[1];
            int flyLenght = int.Parse(curentRow[2]);



        }


    }
}

