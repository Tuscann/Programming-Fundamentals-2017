using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        while (true)
        {
            string[] curentCommand = Console.ReadLine().Split(' ').ToArray();

            if (curentCommand[0] == "Odd")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] % 2 != 0)
                    {
                        Console.Write(input[i] + " ");
                    }
                }
                break;
            }
            if (curentCommand[0] == "Even")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] % 2 == 0)
                    {
                        Console.Write(input[i] + " ");
                    }
                }
                break;
            }
            if (curentCommand[0] == "Delete")
            {
                int number = int.Parse(curentCommand[1]);
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == number)
                    {
                        input.Remove(input[i]);
                        i--;
                    }
                }
            }
            if (curentCommand[0] == "Insert")
            {
                int number = int.Parse(curentCommand[1]);
                int position = int.Parse(curentCommand[2]);

                input.Insert(position, number);
            }
        }
    }
}