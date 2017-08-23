using System;
class Program
{
    static void Main() //100/100
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string operation = Console.ReadLine();
            if (operation == "success")
            {
                string message = Console.ReadLine();
                string message2 = Console.ReadLine();
                Console.WriteLine(ShowSuccess(message, message2));
            }
            else if (operation == "error")
            {
                string message = Console.ReadLine();
                int numbers = int.Parse(Console.ReadLine());
                Console.WriteLine(ShowError(message, numbers));
            }
        }
    }

    static string ShowSuccess(string operation, string message)
    {
        string x = string.Empty;
        return x + "Successfully executed " + operation + "." + "\n"
               + "==============================" + "\n"
               + "Message: " + message + ".";
    }

    static string ShowError(string operation, int code)
    {
        string x = "Error: Failed to execute " + operation + "." + "\n"
             + "==============================" + "\n"
             + "Error Code: " + code + ".\n";

        if (code < 0)
        {
            return x + "Reason: Internal System Failure.";
        }
        return x + "Reason: Invalid Client Data.";
    }

}