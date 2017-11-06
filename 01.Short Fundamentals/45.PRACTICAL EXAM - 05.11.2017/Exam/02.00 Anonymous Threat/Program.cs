using System;
using System.Collections.Generic;   // nice Авторско Решение
using System.Linq;                  // 100/100
using System.Text;

class AnonymousThreat
{
    static void Main()
    {
        List<string> sensitiveData = Console.ReadLine().Split().ToList();

        string inputLine = string.Empty;

        while ((inputLine = Console.ReadLine()) != "3:1")
        {
            string[] inputParameters = inputLine.Split();
            string command = inputParameters[0];

            if (command == "merge")
            {
                int startIndex = int.Parse(inputParameters[1]);
                int endIndex = int.Parse(inputParameters[2]);

                sensitiveData = Merge(sensitiveData, startIndex, endIndex);
            }
            else if (command == "divide")
            {
                int index = int.Parse(inputParameters[1]);
                int partitions = int.Parse(inputParameters[2]);

                sensitiveData = Divide(sensitiveData, index, partitions);
            }
        }
        Console.WriteLine(string.Join(" ", sensitiveData));
    }
    private static int ChangeIndex(int index, int maxLength)
    {
        if (index < 0)
        {
            index = 0;
        }

        if (index >= maxLength)
        {
            index = maxLength - 1;
        }

        return index;
    }

    private static List<string> Merge(List<string> sensitiveData, int startIndex, int endIndex)
    {

        startIndex = ChangeIndex(startIndex, sensitiveData.Count);
        endIndex = ChangeIndex(endIndex, sensitiveData.Count);

        List<string> newList = new List<string>();

        for (int i = 0; i < startIndex; i++)
        {
            newList.Add(sensitiveData[i]);
        }

        StringBuilder result = new StringBuilder();

        for (int i = startIndex; i <= endIndex; i++)
        {
            result.Append(sensitiveData[i]);
        }
        newList.Add(result.ToString());

        for (int i = endIndex + 1; i < sensitiveData.Count; i++)
        {
            newList.Add(sensitiveData[i]);
        }
        return newList;
    }

    private static List<string> Divide(List<string> sensitiveData, int index, int partitions)
    {
        string element = sensitiveData[index];
        int partitionLength = element.Length / partitions;
        List<string> dividedPartitions = new List<string>();

        for (int i = 0; i < partitions; i++)
        {
            if (i == partitions - 1)
            {
                dividedPartitions.Add(element.Substring(i * partitionLength));
            }
            else
            {
                dividedPartitions.Add(element.Substring(i * partitionLength, partitionLength));
            }
        }
        sensitiveData.RemoveAt(index);
        sensitiveData.InsertRange(index, dividedPartitions);

        return sensitiveData;
    }
}