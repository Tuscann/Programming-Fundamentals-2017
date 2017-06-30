using System;
class Program
{
    static void Main()
    {
        char first = char.Parse(Console.ReadLine());
        char secound = char.Parse(Console.ReadLine());
        int counter = int.Parse(Console.ReadLine());
        
        int firstCountMoves = 0;
        int secoundCountMoves = 0;

        for (int i = 1; i <= counter; i++)
        {
            string curentCommand = Console.ReadLine();
            int lengt = curentCommand.Length;

            if (curentCommand == "UPGRADE")
            {
                first += (char)3;
                secound += (char)3;
            }
            if (i % 2 != 0)
            {
                firstCountMoves += lengt;
            }
            else if (i % 2 == 0)
            {
                secoundCountMoves += lengt;
            }

            if (secoundCountMoves >= 50 || firstCountMoves >= 50)
            {
                break;
            }
        }
        if (firstCountMoves >= secoundCountMoves)
        {
            Console.WriteLine(first);
        }
        else
        {
            Console.WriteLine(secound);
        }
    }
}