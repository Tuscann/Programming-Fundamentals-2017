using System;
using System.Collections.Generic;
using System.Linq;
class Point 
{
    public int X { get; set; }
    public int Y { get; set; }

    public static int CalculateWidth(Point p1, Point p2)
    {
        return Math.Abs(p1.X - p2.X);
    }

    public static int CalculateHeight(Point p1, Point p2)
    {
        return Math.Abs(p1.Y - p2.Y);
    }
}

class Box 
{
    public Point UpperLeft { get; set; }
    public Point UpperRight { get; set; }
    public Point BottomLeft { get; set; }
    public Point BottomRight { get; set; }

    public static int CalculatePerimeter(int width, int height)
    {
        return 2 * (width + height);
    }

    public static int CalculateArea(int width, int height)
    {
        return width * height;
    }
}

class Boxes
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        List<Box> boxesList = new List<Box>();

        while (input != "end")
        {
            string[] splitInput = input.Split(new string[] { " | " },
                StringSplitOptions.RemoveEmptyEntries);

            List<Point> pointsList = new List<Point>();

            for (int index = 0; index < splitInput.Length; index++)
            {
                int[] coordinates = splitInput[index].Split(':').Select(int.Parse).ToArray();

                Point point = new Point()
                {
                    X = coordinates[0],
                    Y = coordinates[1]
                };
                pointsList.Add(point);
            }

            Box box = new Box()
            {
                UpperLeft = pointsList[0],
                UpperRight = pointsList[1],
                BottomLeft = pointsList[2],
                BottomRight = pointsList[3],
            };

            boxesList.Add(box);
            input = Console.ReadLine();
        }
        PrintBoxes(boxesList);
    }

    static void PrintBoxes(List<Box> boxesList) 
    {
        foreach (Box box in boxesList)
        {
            Point upperLeft = box.UpperLeft;
            Point upperRight = box.UpperRight;
            Point bottomLeft = box.BottomLeft;

            int width = Point.CalculateWidth(upperRight, upperLeft);
            int height = Point.CalculateHeight(upperLeft, bottomLeft);

            int perimeter = Box.CalculatePerimeter(width, height);
            int area = Box.CalculateArea(width, height);

            Console.WriteLine("Box: {0}, {1}", width, height);
            Console.WriteLine("Perimeter: {0}", perimeter);
            Console.WriteLine("Area: {0}", area);
        }
    }
}