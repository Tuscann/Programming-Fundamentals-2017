using System;
class Program
{
    static void Main()
    {
        int countGroup = int.Parse(Console.ReadLine());

        string size = "";
        double min = double.MinValue;

        for (int i = 0; i < 3 * countGroup; i += 3)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(radius, 2) * height;
            if (volume > min)
            {
                min = volume;
                size = model;
            }
        }
        Console.WriteLine(size);
    }
}