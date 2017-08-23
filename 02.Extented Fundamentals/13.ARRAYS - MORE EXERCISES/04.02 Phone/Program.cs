using System;
using System.Linq;
class Phone
    {
        static void Main() // 100/100
        {
            string[] phones = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();
            string[] commandLine = Console.ReadLine().Split(' ').ToArray();

            while (!commandLine[0].Equals("done"))
            {
                if (commandLine[0].Equals("call"))
                {
                    CallMethod(phones, names, commandLine);
                }
                else if (commandLine[0].Equals("message"))
                {
                    MessageMethod(phones, names, commandLine);
                }

                commandLine = Console.ReadLine().Split(' ').ToArray();
            }
        }
        private static void MessageMethod(string[] phones, string[] names, string[] commandLine)
        {
            long sum = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (commandLine[1].Equals(phones[i]))
                {
                    Console.WriteLine($"sending sms to {names[i]}...");
                    var sumOfDigits = phones[i].ToCharArray();
                    foreach (var x in sumOfDigits)
                    {
                        if (x >= 48 && x <= 57)
                        {
                            sum += x - '0';
                        }
                    }
                }
                else if (commandLine[1].Equals(names[i]))
                {
                    Console.WriteLine($"sending sms to {phones[i]}...");
                    var sumOfDigits = phones[i].ToCharArray();
                    foreach (var x in sumOfDigits)
                    {
                        if (x >= 48 && x <= 57)
                        {
                            sum += x - '0';
                        }
                    }
                }
            }

            if (sum % 2 == 0)
            {
                Console.WriteLine("meet me there");
            }
            else if (sum % 2 != 0)
            {
                Console.WriteLine("busy");
            }
        }

        private static void CallMethod(string[] phones, string[] names, string[] commandLine)
        {
            long duration = 0;
            for (int i = 0; i < names.Length; i++)
            {

                if (commandLine[1].Equals(phones[i]))
                {
                    Console.WriteLine($"calling {names[i]}...");
                    var sumOfDigits = phones[i].ToCharArray();
                    foreach (var x in sumOfDigits)
                    {
                        if (x >= 48 && x <= 57)
                        {
                            duration += x - '0';
                        }
                    }
                }
                else if (commandLine[1].Equals(names[i]))
                {
                    Console.WriteLine($"calling {phones[i]}...");
                    var sumOfDigits = phones[i].ToCharArray();
                    foreach (var x in sumOfDigits)
                    {
                        if (x >= 48 && x <= 57)
                        {
                            duration += x - '0';
                        }
                    }
                }
            }
            if (duration % 2 == 0)
            {
                TimeSpan t = TimeSpan.FromSeconds(duration);
                string answer = string.Format("call ended. duration: {0:D2}:{1:D2}",
                    t.Minutes,
                    t.Seconds);
                Console.WriteLine(answer);
            }
            else if (duration % 2 != 0)
            {
                Console.WriteLine("no answer");
            }
        }
    }
