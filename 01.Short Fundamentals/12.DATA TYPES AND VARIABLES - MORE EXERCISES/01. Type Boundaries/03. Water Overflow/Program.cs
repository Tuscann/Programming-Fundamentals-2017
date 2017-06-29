using System;
class Program
{
    static void Main()
    {
        int counter = int.Parse(Console.ReadLine());
        int capacity = 255;
        int begin = capacity;

        for (int i = 0; i < counter; i++)
        {
            int curent = int.Parse(Console.ReadLine());
            capacity -= curent;
           
            if (capacity < 0)
            {
                capacity += curent;
                Console.WriteLine("Insufficient capacity!");
            }
        }
        Console.WriteLine(begin - capacity);
    }
}