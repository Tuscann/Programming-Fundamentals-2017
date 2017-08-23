using System;
using System.Collections.Generic;
using System.Linq;
class SquareNumbers
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        List<string> splitInput = input.Split(' ').ToList();
        List<int> numbers = new List<int>();

        for (int i = 0; i < splitInput.Count; i++)
        {
            numbers.Add(int.Parse(splitInput[i]));
        }

        List<int> squareNumbers = new List<int>();
        for (int cnt = 0; cnt < numbers.Count; cnt++)
        {
            int currentNumber = numbers[cnt];
            if (Math.Sqrt(currentNumber) == (int)Math.Sqrt(currentNumber))
            {
                squareNumbers.Add(currentNumber);
            }
        }
        squareNumbers.Sort();
        squareNumbers.Reverse();
        Console.WriteLine(String.Join(" ", squareNumbers));
    }
}