using System;
class Program
{
    static void Main()
    {
        int counter = 0;
        while (true)
        {
            string x = Console.ReadLine();

            int value;
            if (int.TryParse(x, out value))
            {
                counter++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(counter);
    }
}