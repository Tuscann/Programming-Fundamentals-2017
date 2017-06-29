using System;
class Program
{
    static void Main()
    {
        string delimeter = Console.ReadLine();
        string oddOrEven = Console.ReadLine();
        int counter = int.Parse(Console.ReadLine());

        string sum = "";

        for (int i = 0; i < counter; i++)
        {
            string cuurent = Console.ReadLine();

            if (oddOrEven == "even" && i % 2 == 1)
            {
                sum += cuurent + delimeter;
            }
            else if (oddOrEven == "odd" && i % 2 == 0)
            {
                sum += cuurent + delimeter;
            }
        }
        Console.WriteLine(sum.Remove(sum.Length - 1, 1));
    }
}