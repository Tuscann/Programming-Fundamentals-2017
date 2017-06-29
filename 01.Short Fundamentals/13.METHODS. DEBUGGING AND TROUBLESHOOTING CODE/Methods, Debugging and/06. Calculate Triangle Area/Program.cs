using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate_Triangle_Area
{
    class Program
    {
        static double calculateTriangleArea(int bases, int height)
        {
            double area = bases * height / 2;

            return area;
        }
        static void Main()
        {
            int bases = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double area = calculateTriangleArea(bases, height);
            Console.WriteLine(area);

        }
    }
}
