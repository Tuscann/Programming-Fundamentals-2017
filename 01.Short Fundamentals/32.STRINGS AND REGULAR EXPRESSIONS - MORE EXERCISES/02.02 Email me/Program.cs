using System;
using System.Linq;
public class Email_Me
{
    public static void Main() // 100/100
    {
        string[] email = Console.ReadLine().Split(new[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

        int firstPartSum = email.First().Sum(c => c);
        int secondPartSum = email.Last().Sum(c => c);

        int subtraction = secondPartSum - firstPartSum;

        Console.WriteLine(subtraction <= 0 ? "Call her!" : "She is not the one.");
    }
}