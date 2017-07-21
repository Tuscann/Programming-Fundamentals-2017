using System;
class Program
{
    static void Main()
    {
        string x = Console.ReadLine();
        string[] val = x.Split(' ');

        int left1 = int.Parse(val[0]);
        int top1 = int.Parse(val[1]);
        int wight1 = int.Parse(val[2]);
        int height1 = int.Parse(val[3]);

        string y = Console.ReadLine();
        string[] valy = y.Split(' ');

        int left2 = int.Parse(valy[0]);
        int top2 = int.Parse(valy[1]);
        int wight2 = int.Parse(valy[2]);
        int height2 = int.Parse(valy[3]);
        
        if (left2 <= left1 && top2 >= top1 && wight2 >= wight1 && height2 >= height1 &&
            left2 + wight2 >= left1 + wight1 && top2 + height2 >= top1 + height1)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not inside");
        }
    }
}