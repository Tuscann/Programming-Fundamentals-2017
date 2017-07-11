using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();

        string strRverse = null;
        int lenght = input.Length - 1;

        while (lenght >= 0)
        {
            strRverse += input[lenght];
            lenght--;
        }
        if (string.Join("",input) == strRverse)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}