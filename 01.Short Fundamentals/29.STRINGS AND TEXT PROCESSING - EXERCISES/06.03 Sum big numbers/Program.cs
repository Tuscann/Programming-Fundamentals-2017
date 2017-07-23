using System;
using System.Text;

public class SumBigNumbers
{
    public static void Main()
    {
        string firstInput = Console.ReadLine().TrimStart('0');
        string secondInput = Console.ReadLine().TrimStart('0');
        string firstNumber = string.Empty;
        string secondNumber = string.Empty;

        if (firstInput.Length <= secondInput.Length)
        {
            firstNumber = firstInput;
            secondNumber = secondInput;
        }
        else
        {
            firstNumber = secondInput;
            secondNumber = firstInput;
        }

        int index = firstNumber.Length - 1;
        StringBuilder sb = new StringBuilder();
        int reminder = 0;

        for (int i = secondNumber.Length - 1; i >= 0; i--)
        {
            int firstDigit = int.Parse(secondNumber[i].ToString());
            int secondDigit = 0;

            if (index < 0)
            {
                secondDigit = 0;
            }
            else
            {
                secondDigit = int.Parse(firstNumber[index].ToString());
            }
            int sum = firstDigit + secondDigit + reminder;
            reminder = 0;
            index--;

            if (sum > 9)
            {
                reminder = sum / 10;
                sum = sum % 10;
            }

            if (sb.Length < 1)
            {
                sb.Append(sum);
            }
            else
            {
                sb.Insert(0, sum);
            }
        }
        if (reminder > 0)
        {
            sb.Insert(0, reminder);
        }
        Console.WriteLine(string.Join("", sb));
    }
}