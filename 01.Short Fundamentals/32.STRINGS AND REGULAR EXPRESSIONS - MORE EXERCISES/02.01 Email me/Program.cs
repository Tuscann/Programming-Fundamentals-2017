using System;
class Program
{
    static void Main() // 100/100
    {
        string email = Console.ReadLine();

        int indexOfA = email.IndexOf('@');

        int beforeA = 0;
        int afterA = 0;

        for (int i = 0; i < indexOfA; i++)
        {
            beforeA += email[i];
        }

        for (int k = indexOfA + 1; k < email.Length; k++)
        {
            afterA += email[k];
        }

        int result = beforeA - afterA;

        if (result >= 0)
        {
            Console.WriteLine("Call her!");
        }
        else
        {
            Console.WriteLine("She is not the one.");
        }
    }
}
