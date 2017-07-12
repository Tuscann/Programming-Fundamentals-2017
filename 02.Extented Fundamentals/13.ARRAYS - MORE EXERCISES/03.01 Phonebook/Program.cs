using System;
public class PhoneBookSimpleArr
{
    static void Main()
    {
        string[] nums = Console.ReadLine().Split(' ');
        string[] names = Console.ReadLine().Split(' ');
        
        while (true)
        {
            string input = Console.ReadLine();

            if (input=="done")
            {
                break;
            }
            int enterNameIndex = Array.IndexOf(names, input);
            Console.WriteLine("{0} -> {1}", input, nums[enterNameIndex]);
        }
    }
}