using System;
class Program
    {
        static void Main()  //  100/100
        {
            string figureType = Console.ReadLine();

            if (figureType == "triangle")
            {
                Triangle();
            }
            else if (figureType == "square")
            {
                Square();
            }
            else if (figureType == "rectangle")
            {
                Rectangle();
            }
            else if (figureType == "circle")
            {
                Circle();
            }
        }

        private static void Circle()
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"{area:F2}");
        }

        private static void Rectangle()
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double area = width * hight;

            Console.WriteLine($"{area:F2}");
        }

        private static void Square()
        {
            double side = double.Parse(Console.ReadLine());

            double area = Math.Pow(side, 2);

            Console.WriteLine($"{area:F2}");
        }

        private static void Triangle()
        {
            double side = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double area = side * hight / 2;

            Console.WriteLine($"{area:F2}");
        }
    }