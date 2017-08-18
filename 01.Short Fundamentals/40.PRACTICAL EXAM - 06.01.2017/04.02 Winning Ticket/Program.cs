using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{ 
    public static void Main() // 100/100
    {
        string[] tickets = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(t => t.Trim()).ToArray();

        foreach (string ticket in tickets)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
            }
            else
            {
                string left = new string(ticket.Take(10).ToArray());
                string right = new string(ticket.Skip(10).ToArray());

                string[] winningSymbols = new string[] { "@", "#", "\\$", "\\^" };
                bool winningTicket = false;

                foreach (string winningSymbol in winningSymbols)
                {
                    Regex regex = new Regex($"{winningSymbol}{{6,}}");
                    Match leftMatch = regex.Match(left);
                    if (leftMatch.Success)
                    {
                        Match rightMatch = regex.Match(right);
                        if (rightMatch.Success)
                        {
                            winningTicket = true;

                            int leftSymbolsLength = leftMatch.Value.Length;
                            int rightSymbolsLength = rightMatch.Value.Length;
                            string jackpot = leftSymbolsLength == 10 && rightSymbolsLength == 10
                                ? " Jackpot!"
                                : string.Empty;

                            Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftSymbolsLength, rightSymbolsLength)}{winningSymbol.Trim('\\')}{jackpot}");

                            break;
                        }
                    }
                }
                if (!winningTicket)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}