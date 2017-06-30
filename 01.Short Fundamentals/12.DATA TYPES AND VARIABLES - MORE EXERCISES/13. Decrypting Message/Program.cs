using System;
class Program
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int numberLines = int.Parse(Console.ReadLine());

        string print = "";

        for (int i = 0; i < numberLines; i++)
        {
            char curentChar = char.Parse(Console.ReadLine());

            print += (char)(curentChar + key);
        }
        Console.WriteLine(print);
    }
}
