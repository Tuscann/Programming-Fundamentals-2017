using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var banksAndUsersAndBalances = new Dictionary<string, Dictionary<string, decimal>>();
            string intro = Console.ReadLine();
            while (intro != "end")
            {
                string[] threeParts = intro.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string bank = threeParts[0];
                string user = threeParts[1];
                decimal balance = decimal.Parse(threeParts[2]);
                if (!banksAndUsersAndBalances.ContainsKey(bank))
                    banksAndUsersAndBalances.Add(bank, new Dictionary<string, decimal>());
                if (!banksAndUsersAndBalances[bank].ContainsKey(user))
                    banksAndUsersAndBalances[bank].Add(user, 0);
                banksAndUsersAndBalances[bank][user] = banksAndUsersAndBalances[bank][user] + balance;
                intro = Console.ReadLine();
            }
            banksAndUsersAndBalances = banksAndUsersAndBalances.
                OrderByDescending(a => a.Value.Values.Sum()).ThenByDescending(b => b.Value.Values.Max()).
                ToDictionary(a => a.Key, b => b.Value);

            foreach (var bank in banksAndUsersAndBalances)
            {
                foreach (var user in bank.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("{0} -> {1} ({2})", user.Key,user.Value,bank.Key);
                }
            }
        }
    }
}