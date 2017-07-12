using System;
class Program
{
    static void Main()
    {
        int range = int.Parse(Console.ReadLine());
        bool[] answer = new bool[range + 1];

        for (int i = 2; i <= range; i++)
        {
            answer[i] = true;
        }
        for (int i = 0; i < answer.Length; i++)
        {
            if (answer[i] == true)
            {
                for (int a = 2; a * i <= range; a++)
                {
                    answer[a * i] = false;
                }
            }
        }
        for (int j = 2; j <= range; j++)
        {
            if (answer[j] == true)
            {
                Console.Write(j + " ");
            }
        }
    }
}