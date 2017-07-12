using System;
public class Phone
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] people = Console.ReadLine().Split();

            string input = Console.ReadLine();

            while (!input.Equals("done"))
            {
                string[] command = input.Split();

                if (command[0].Equals("call"))
                {
                    if (char.IsDigit(command[1][command.Length - 1])) 
                        // We get the string at position 1 of the user input(a number or a name) and if the LAST character of this string is a digit we know that we have the phone. If not, then we have the name. We are checking the last character because the first one can be '+' but the last one can be only a digit or a letter.
                    {
                        int phoneIndex = Array.IndexOf(phoneNumbers, command[1]);
                        Console.WriteLine($"calling {people[phoneIndex]}...");
                        string phoneNumber = command[1];

                        PrintCallSummary(phoneNumber);
                    }
                    else
                    {
                        int personIndex = Array.IndexOf(people, command[1]);
                        Console.WriteLine($"calling {phoneNumbers[personIndex]}...");
                        string phoneNumber = phoneNumbers[personIndex];

                        PrintCallSummary(phoneNumber);
                    }
                }
                else if (command[0].Equals("message"))
                {
                    if (char.IsDigit(command[1][command.Length - 1])) // We get the string at position 1 of the user input(a number or a name) and if the LAST character of this string is a digit we know that we have the phone. If not, then we have the name. We are checking the last character because the first one can be '+' but the last one can be only a digit or a letter.
                    {
                        int phoneIndex = Array.IndexOf(phoneNumbers, command[1]);
                        Console.WriteLine($"sending sms to {people[phoneIndex]}...");
                        string phoneNumber = command[1];

                        PrintMessageResult(phoneNumber);

                    }
                    else
                    {
                        int personIndex = Array.IndexOf(people, command[1]);
                        Console.WriteLine($"sending sms to {phoneNumbers[personIndex]}...");
                        string phoneNumber = phoneNumbers[personIndex];

                        PrintMessageResult(phoneNumber);
                    }
                }
                else
                {
                    string currentPerson = command[0];
                    int nameIndex = Array.IndexOf(people, currentPerson);

                    Console.WriteLine($"{currentPerson} -> {phoneNumbers[nameIndex]}");
                }

                input = Console.ReadLine();
            }
        }

        public static void PrintCallSummary(string number)
        {
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int currentDigit = 0;

                // By using TryParse() we are checking if the current character of the number is integer(e.g. '+' is not). If it is true we keep the digit in the variable after keyword "out" of the method. If it is false we don't do anything with it.

                bool isTheCharDigit = int.TryParse(number[i].ToString(), out currentDigit);
                sum += currentDigit;
            }

            if (sum % 2 == 1)
            {
                Console.WriteLine("no answer");
            }
            else
            {
                int minutes = sum / 60;
                int seconds = sum % 60;

                Console.WriteLine($"call ended. duration: {minutes:D2}:{seconds:D2}");
            }
        }

        public static void PrintMessageResult(string number)
        {
            int difference = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int currentDigit = 0;

                bool isTheCharDigit = int.TryParse(number[i].ToString(), out currentDigit);
                difference -= currentDigit;
            }

            if (difference % 2 == -1)
            {
                Console.WriteLine("busy");
            }
            else
            {
                Console.WriteLine("meet me there");
            }
        }
    }