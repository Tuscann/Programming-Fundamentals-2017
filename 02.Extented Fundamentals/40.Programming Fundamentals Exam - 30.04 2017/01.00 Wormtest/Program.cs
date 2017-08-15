using System;
class Program
{
    static void Main()  // 100/100
    {
        double lenght = double.Parse(Console.ReadLine()) * 100;
        double width = double.Parse(Console.ReadLine());

        if (lenght % width == 0 || width == 0)
        {
            Console.WriteLine("{0:f2}", lenght * width);
        }
        else
        {
            Console.WriteLine("{0:f2}%", lenght / width * 100);
        }
    }
}