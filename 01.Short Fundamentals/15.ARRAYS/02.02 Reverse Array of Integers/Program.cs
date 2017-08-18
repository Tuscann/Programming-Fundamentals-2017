using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int rotation = int.Parse(Console.ReadLine());

        int[] answer = new int[rotation];

        for (int cycle = 0; cycle < rotation; cycle++)
        {
            int insertInTheArray = int.Parse(Console.ReadLine());
            answer[cycle] = insertInTheArray;
        }
        int[] realAnswer = answer.Reverse().ToArray();
        Console.WriteLine(string.Join(" ", realAnswer));
    }
}