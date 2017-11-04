using System;
class Program
{
    static void Main()
    {
        string figure = Console.ReadLine();

        if (figure == "square")
        {
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.000}", firstNumber * firstNumber);
        }
        else if (figure == "rectangle")
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.000}", firstNumber * secondNumber);
        }
        else if (figure == "circle")
        {
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.000}", (Math.PI) * (Math.Pow(firstNumber, 2)));
        }
        else if (figure == "triangle")
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.000}", firstNumber * secondNumber * 0.5);
        }
    }
}