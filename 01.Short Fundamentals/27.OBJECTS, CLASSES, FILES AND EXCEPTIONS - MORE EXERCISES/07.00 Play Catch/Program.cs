using System;
using System.Collections.Generic;
using System.Linq;

class P07_PlayCatch
{
    static void Main() // 100/100
    {
        Catch3Exeptions();
    }

    static void Catch3Exeptions()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int exeptionsLeft = 3;
        while (exeptionsLeft > 0)
        {
            string command = Console.ReadLine();
            string instuction = command.Split(' ').First();
            string[] commandList = command.Split(' ').Skip(1).ToArray();

            try
            {
                switch (instuction)
                {
                    case "Replace":
                        RaplaceNum(nums, commandList);
                        break;
                    case "Print":
                        PrintNumRange(nums, commandList);
                        break;
                    case "Show":
                        PrintNumAt(nums, commandList);
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("The variable is not in the correct format!");
                exeptionsLeft--;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The index does not exist!");
                exeptionsLeft--;
            }
        }

        Console.WriteLine(string.Join(", ", nums));
    }

    static void PrintNumAt(int[] nums, string[] commandList)
    {
        int index = int.Parse(commandList[0]);
        Console.WriteLine(nums[index]);
    }

    static void PrintNumRange(int[] nums, string[] commandList)
    {
        int startIndex = int.Parse(commandList[0]);
        int end = int.Parse(commandList[1]);
        List<int> result = new List<int>();
        for (int i = startIndex; i <= end; i++)
        {
            result.Add(nums[i]);
        }
        Console.WriteLine(string.Join(", ", result));
    }

    static void RaplaceNum(int[] nums, string[] commandList)
    {
        int index = int.Parse(commandList[0]);
        nums[index] = int.Parse(commandList[1]);
    }
}