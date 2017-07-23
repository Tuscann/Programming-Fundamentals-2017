using System;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string[] inputTickets = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();

        string ticketPattern = @"@{6,9}|#{6,9}|\${6,9}|\^{6,9}";
        Regex winningTicket = new Regex(ticketPattern);
        string jackpotPattern = @"@{10}|#{10}|\${10}|\^{10}";
        Regex winJackpot = new Regex(jackpotPattern);

        for (int i = 0; i < inputTickets.Length; i++)
        {
            string currentTicket = inputTickets[i];

            if (currentTicket.Length == 20)
            {
                string leftPart = currentTicket.Substring(0, 10);
                string rightPart = currentTicket.Substring(10, 10);

                Match matchedLeftPartForJackpot = winJackpot.Match(leftPart);
                Match matchedRightPartForJackpot = winJackpot.Match(rightPart);

                Match matchedWinningTicketLeftPart = winningTicket.Match(leftPart);
                Match matchedWinningTicketRightPart = winningTicket.Match(rightPart);

                if (matchedLeftPartForJackpot.Success && matchedRightPartForJackpot.Success)
                {
                    if (leftPart == rightPart)
                    {
                        char winningSymbol = leftPart[0];
                        Console.WriteLine($"ticket \"{currentTicket}\" - 10{winningSymbol} Jackpot!");
                    }
                    if (leftPart[5] == rightPart[5])
                    {
                        char winningSymbol = leftPart[5];
                        int minimumMachedWinSymbols = Math.Min(matchedWinningTicketRightPart.Value.Count(), matchedWinningTicketLeftPart.Value.Count());

                        Console.WriteLine($"ticket \"{currentTicket}\" - {minimumMachedWinSymbols}{winningSymbol}");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                }
            }
            else
            {
                Console.WriteLine("invalid ticket");
            }
        }
    }
}