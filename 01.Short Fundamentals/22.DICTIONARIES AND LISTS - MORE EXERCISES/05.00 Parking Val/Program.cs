using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] curent = Console.ReadLine().Split(' ').ToArray();

            string action = curent[0];
            string userName = curent[1]; ;
            string licensePlateNumber = String.Empty;

            if (action == "unregister")
            {
                if (dic.ContainsKey(userName))
                {
                    Console.WriteLine("user {0} unregistered successfully", userName);
                    dic.Remove(userName);
                }
                else if (!dic.ContainsKey(userName))
                {
                    Console.WriteLine("ERROR: user {0} not found", userName);
                }

            }
            if (action == "register")
            {
                licensePlateNumber = curent[2];

                if (dic.ContainsKey(userName))
                {
                    Console.WriteLine("ERROR: already registered with plate number {0}", dic[userName]);
                }
                if (dic.ContainsValue(licensePlateNumber))
                {
                    Console.WriteLine("ERROR: license plate {0} is busy", licensePlateNumber);
                    continue;
                }
                if (!dic.ContainsKey(userName))
                {
                    string firstTwo = licensePlateNumber.Substring(0, 2);
                    string lastTwo = licensePlateNumber.Substring(licensePlateNumber.Length - 2, 2);
                    string middle = licensePlateNumber.Substring(2, 4);
                    bool isdigit = middle.All(char.IsDigit);
                    
                    if (licensePlateNumber.Length == 8 && isdigit && firstTwo == firstTwo.ToUpper() && lastTwo == lastTwo.ToUpper())
                    {
                        dic[userName] = licensePlateNumber;
                        Console.WriteLine("{0} registered {1} successfully", userName, dic[userName]);
                    }
                    else
                    {
                        Console.WriteLine("ERROR: invalid license plate {0}", licensePlateNumber);
                    }
                }
            }
        }
        foreach (KeyValuePair<string, string> user in dic)
        {
            Console.WriteLine("{0} => {1}", user.Key, user.Value);
        }
    }
}