using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        string[] outputs = new string[tickets.Length];
        char[] winningSymbols = { '@', '$', '#', '^' };
        for (int i = 0; i < tickets.Length; i++)
        {
            string currentTicket = tickets[i];
            if (currentTicket.Length != 20)
            {
                outputs[i] = "invalid ticket";
            }
            else
            {
                char currentCharLeft = currentTicket[0];
                int timesInRowLeft = 0;
                bool winningLeft = false;
                for (int j = 0; j < 10; j++)
                {
                    if (currentTicket[j] == currentCharLeft)
                    {
                        timesInRowLeft++;
                    }
                    else if (!winningLeft)
                    {
                        timesInRowLeft = 1;
                        currentCharLeft = currentTicket[j];
                    }

                    if (timesInRowLeft >= 6)
                    {
                        winningLeft = true;
                    }
                }

                if (winningLeft && winningSymbols.Contains(currentCharLeft))
                {
                    char currentCharRight = currentTicket[19];
                    int timesInRowRight = 0;
                    bool winningRight = false;
                    for (int j = 19; j >= 10; j--)
                    {
                        if (currentCharRight == currentTicket[j])
                        {
                            timesInRowRight++;
                        }
                        else if (!winningRight)
                        {
                            timesInRowRight = 1;
                            currentCharRight = currentTicket[j];
                        }

                        if (timesInRowRight >= 6)
                        {
                            winningRight = true;
                        }
                    }

                    if (winningRight && currentCharLeft == currentCharRight)
                    {
                        int lengthChars = timesInRowLeft > timesInRowRight ? timesInRowRight : timesInRowLeft;
                        if (timesInRowRight == 10 && timesInRowLeft == 10)
                        {
                            outputs[i] = $"ticket \"{currentTicket}\" - {lengthChars}{currentCharRight} Jackpot!";
                        }
                        else
                        {
                            outputs[i] = $"ticket \"{currentTicket}\" - {lengthChars}{ currentCharRight}";
                        }
                    }
                    else
                    {
                        outputs[i] = $"ticket \"{currentTicket}\" - no match";
                    }
                }
                else
                {
                    outputs[i] = $"ticket \"{currentTicket}\" - no match";
                }
            }
        }

        foreach (string output in outputs)
        {
            Console.WriteLine(output);
        }
    }
}