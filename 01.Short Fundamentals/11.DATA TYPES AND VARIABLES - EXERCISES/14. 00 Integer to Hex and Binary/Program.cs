using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        string hexadecimal = number.ToString("X");
        string binary = Convert.ToString(number, 2).ToUpper();

        Console.WriteLine("{0}\n{1}", hexadecimal, binary);
    }
}
