using System;
public class Notifications
{
    public static void Main() // 100/100
    {
        var numberCounts = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberCounts; i++)
        {
            var successOrError = Console.ReadLine();

            if (successOrError == "success")
            {
                string Soperation = Console.ReadLine();
                string Smessage = Console.ReadLine();
                string success = ShowSuccess(Soperation, Smessage);

                Console.WriteLine(success);
            }

            else if (successOrError == "error")
            {
                string Eoperation = Console.ReadLine();
                var code = int.Parse(Console.ReadLine());
                string error = ShowError(Eoperation, code);

                Console.WriteLine(error);
            }
        }

    }

    public static string ShowSuccess(string operation, string message)
    {
        return $"Successfully executed {operation}.\n==============================\nMessage: {message}.";
    }

    public static string ShowError(string operation, int code)
    {
        if (code > 0)
        {
            return $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: Invalid Client Data.";
        }
        return $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: Internal System Failure.";
    }
}