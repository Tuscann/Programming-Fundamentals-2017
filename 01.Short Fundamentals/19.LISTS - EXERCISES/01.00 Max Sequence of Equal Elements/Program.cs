using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        list.Reverse();
        int curentCounter = 0;
        int maxCounter = 0;
        int curentdigit = 0;
        int maxdigit = 0;

        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] == list[i + 1])
            {
                curentCounter++;
                curentdigit = list[i];
                if (curentCounter >= maxCounter)
                {
                    maxCounter = curentCounter;
                    maxdigit = curentdigit;
                }
            }
            else
            {
                curentCounter = 0;
            }
        }
        for (int i = 0; i <= maxCounter; i++)
        {
            Console.Write(maxdigit + " ");
        }
    }
}