using System;
using System.Linq;
class Program
{
    static void Main()
    {
        Rectangle firstRectangle = ReadRectangle();
        Rectangle secondRectangle = ReadRectangle();

        bool result = firstRectangle.IsInside(secondRectangle);

        string printResult = result ? $"Inside" : $"Not inside";

        Console.WriteLine(printResult);
    }

    public static Rectangle ReadRectangle()
    {
        int[] rectangleParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Rectangle rect = new Rectangle
        {
            Left = rectangleParts[0],
            Top = rectangleParts[1],
            Width = rectangleParts[2],
            Height = rectangleParts[3]
        };
        return rect;
    }

    public class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public int CalcArea()
        {
            return Height * Width;
        }

        public bool IsInside(Rectangle rectangle)
        {
            bool isLeftValid = rectangle.Left <= Left;
            bool isTopValid = rectangle.Top <= Top;
            bool isRightValid = rectangle.Right >= Right;
            bool isBottomValid = rectangle.Bottom >= Bottom;

            return isLeftValid && isTopValid && isRightValid && isBottomValid;
        }

    }
}