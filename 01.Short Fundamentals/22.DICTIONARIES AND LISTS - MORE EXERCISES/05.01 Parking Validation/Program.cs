using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {

       // 90/100  find the mistake

        int rotation = int.Parse(Console.ReadLine());

        Dictionary<string, string> personPlate = new Dictionary<string, string>();

        for (int cycle = 0; cycle < rotation; cycle++)
        {
            string[] inputLine = Console.ReadLine().Split();

            string command = inputLine[0];
            string parkingPerson = inputLine[1];

            if (command == "register")
            {
                string licensePlate;
                bool firstPositive, secondPositive;
                CheckIfTheLicensePlateIsCorrect(inputLine, out licensePlate, out firstPositive, out secondPositive);

                if (firstPositive == true && secondPositive == true)
                {
                    if (personPlate.ContainsKey(parkingPerson))
                    {
                        Console.WriteLine("ERROR: already registered with plate number {0}", licensePlate);
                    }
                    else if (personPlate.ContainsValue(licensePlate))
                    {
                        Console.WriteLine("ERROR: license plate {0} is busy", licensePlate);
                    }
                    else
                    {
                        Console.WriteLine("{0} registered {1} successfully", parkingPerson, licensePlate);
                        personPlate.Add(parkingPerson, licensePlate);
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: invalid license plate {0}", licensePlate);
                }

            }
            else if (command == "unregister")
            {
                if (!personPlate.ContainsKey(parkingPerson))
                {
                    Console.WriteLine("ERROR: user {0} not found", parkingPerson);
                }
                else
                {
                    Console.WriteLine("user {0} unregistered successfully", parkingPerson);
                    personPlate.Remove(parkingPerson);
                }
            }
        }

        foreach (KeyValuePair<string, string> kvp in personPlate)
        {
            Console.WriteLine("{0} => {1}", kvp.Key, kvp.Value);
        }

    }

    private static void CheckIfTheLicensePlateIsCorrect(string[] inputLine,
        out string licensePlate, out bool firstPositive, out bool secondPositive)
    {
        licensePlate = inputLine[2];
        firstPositive = false;
        secondPositive = false;
        char[] checkIfItIsARealPlate = licensePlate.ToCharArray();

        string checkUpper = string.Empty;
        checkUpper += checkIfItIsARealPlate[0].ToString()
                      + checkIfItIsARealPlate[1].ToString()
                      + checkIfItIsARealPlate[6].ToString()
                      + checkIfItIsARealPlate[7].ToString();

        if (checkUpper == checkUpper.ToUpper())
        {
            firstPositive = true;
        }

        int totalSumOfTheFourDigits = 0;

        List<char> checkIfItIsARealPlateDigits = licensePlate.Skip(2).Take(4).ToList(); 

        for (int cycle2 = 0; cycle2 < 4; cycle2++)
        {
            totalSumOfTheFourDigits += checkIfItIsARealPlateDigits[cycle2];
        }

        if (48 <= totalSumOfTheFourDigits && totalSumOfTheFourDigits <= 228)
        {
            secondPositive = true;
        }
    }
}
