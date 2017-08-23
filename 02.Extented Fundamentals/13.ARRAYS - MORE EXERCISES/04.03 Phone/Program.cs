using System;
public class Phone
{
    static void Main() // 100/100
    {
        string[] phonenumbers = Console.ReadLine().Split();
        string[] names = Console.ReadLine().Split();

        string input = Console.ReadLine();

        while (!input.Equals("done"))
        {
            string[] inputCommands = input.Split();
            string command = inputCommands[0];
            string nameNumber = inputCommands[1];

            for (int i = 0; i < names.Length; i++)
            {
                if (command.Equals("call"))
                {
                    if (nameNumber.Equals(phonenumbers[i]))
                    {
                        CallNumber(phonenumbers[i], names[i]);
                    }
                    else if (nameNumber.Equals(names[i]))
                    {
                        CallName(phonenumbers[i]);
                    }
                }
                if (command.Equals("message"))
                {
                    if (nameNumber.Equals(phonenumbers[i]))
                    {
                        MessageNumber(phonenumbers[i], names[i]);
                    }

                    else if (nameNumber.Equals(names[i]))
                    {
                        MessageName(phonenumbers[i]);
                    }
                }
            }
            input = Console.ReadLine();
        }
    }

    private static void MessageNumber(string v1, string v2)
    {
        Console.WriteLine($"sending sms to {v2}...");

        int sum = 0;
        for (int i = 0; i < v1.Length; i++)
        {
            if (v1[i] >= 49 && v1[i] <= 57)
            {
                sum += v1[i] - 48;
            }
        }
        if (sum % 2 == 0)
        {
            Console.WriteLine("meet me there");
        }
        else
        {
            Console.WriteLine("busy");
        }
    }

    private static void MessageName(string v2)
    {
        Console.WriteLine($"sending sms to {v2}...");

        int sum = 0;
        foreach (char t in v2)
        {
            if (t >= 49 && t <= 57)
            {
                sum += t - 48;
            }
        }
        Console.WriteLine(sum % 2 == 0 ? "meet me there" : "busy");
    }

    private static void CallName(string v2)
    {
        Console.WriteLine($"calling {v2}...");

        int sum = 0;
        foreach (char t in v2)
        {
            if (t >= 49 && t <= 57)
            {
                sum += t - 48;
            }
        }
        TimeSpan time = TimeSpan.FromSeconds(sum);

        if (sum % 2 == 0)
        {
            Console.WriteLine("call ended. duration: {0:00}:{1:00}", time.Minutes, time.Seconds);
        }
        else
        {
            Console.WriteLine("no answer");
        }
    }
    private static void CallNumber(string v1, string v2)
    {
        Console.WriteLine($"calling {v2}...");

        int sum = 0;
        for (int i = 0; i < v1.Length; i++)
        {
            if (v1[i] >= 49 && v1[i] <= 57)
            {
                sum += v1[i] - 48;
            }
        }
        TimeSpan time = TimeSpan.FromSeconds(sum);

        switch (sum % 2)
        {
            case 0:
                Console.WriteLine("call ended. duration: {0:00}:{1:00}", time.Minutes, time.Seconds);
                break;
            default:
                Console.WriteLine("no answer");
                break;
        }
    }
}