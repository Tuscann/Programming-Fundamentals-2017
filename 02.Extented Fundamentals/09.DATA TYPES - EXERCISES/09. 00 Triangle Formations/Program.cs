using System;
class TriangleFormation
{
    static void Main() // 100/100
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        bool isValid = false;

        if ((a + b > c) && (a + c > b) && (b + c > a))
        {
            isValid = true;
        }

        if (isValid)
        {
            Console.WriteLine("Triangle is valid.");

            bool hasRightAngle = false;
            string betweenSides = String.Empty;

            if ((a * a + b * b == c * c))
            {
                hasRightAngle = true;
                betweenSides = "a and b";
            }
            else if ((c * c + b * b == a * a))
            {
                hasRightAngle = true;
                betweenSides = "b and c";
            }
            else if ((c * c + a * a == b * b))
            {
                hasRightAngle = true;
                betweenSides = "a and c";
            }

            if (hasRightAngle)
            {
                Console.WriteLine("Triangle has a right angle between sides " + betweenSides);
            }
            else
            {
                Console.WriteLine("Triangle has no right angles");
            }
        }
        else
        {
            Console.WriteLine("Invalid Triangle.");
        }
    }
}