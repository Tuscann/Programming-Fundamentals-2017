using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        
        string winner = "";
        int winnerPoints = -100000;

        //Create a list of the students & student points
        List<string> students = new List<string>();
        List<int> studentPoints = new List<int>();

        //Split the entries into the lists
        for (int i = 0; i < n; i++)
        {
            students.Add(Console.ReadLine());
            studentPoints.Add(int.Parse(Console.ReadLine()));
        }

        for (int i = 0; i < n; i++)
        {
            //Use Current Student's name             
            string name = students[i];
            int points = 0;
            points += studentPoints[i];

            //Acquire Current Student's Points
            foreach (char c in name)
            {
                if (c % 2 == 0)
                {
                    points += c;
                }
                else
                {
                    points -= c;
                }
            }

            //Check who has the highest number of points             
            if (points > winnerPoints)
            {
                winner = name;
                winnerPoints = points;
            }
        }
        Console.WriteLine("The winner is {0} - {1} points", winner, winnerPoints);
    }
}