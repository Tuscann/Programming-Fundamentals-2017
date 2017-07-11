using System;
class Program
{
    static void Main()
    {
        int counter = int.Parse(Console.ReadLine());
        string ingridient;
        int sum = 0;

        for (int i = 0; i < counter; i++)
        {
            ingridient = Console.ReadLine().ToLower();
            if (ingridient == "cheese")
            {
                sum += 500;
            }
            else if (ingridient == "tomato sauce")
            {
                sum += 150;
            }
            else if (ingridient == "salami")
            {
                sum += 600;
            }
            else if (ingridient == "pepper")
            {
                sum += 50;
            }
        }
        Console.WriteLine("Total calories: {0}", sum);
    }
}