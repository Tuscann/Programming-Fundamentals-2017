using System;
using System.Collections.Generic;
using System.Linq;
class OptimizedBankingSystem
{
    static void Main() // 100/100
    {
        List<BankAccount> newBankAccounts = new List<BankAccount>();
        newBankAccounts = GetBankAccounts(newBankAccounts);
        PrintBankAccounts(newBankAccounts);
    }

    static List<BankAccount> GetBankAccounts(List<BankAccount> newBankAccounts)
    {
        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] accountData = input.Split(new string[] { " | " },
                StringSplitOptions.RemoveEmptyEntries);

            BankAccount account = new BankAccount
            {
                Bank = accountData[0],
                AccountName = accountData[1],
                Balance = decimal.Parse(accountData[2]),
            };

            newBankAccounts.Add(account);
            input = Console.ReadLine();
        }
        return newBankAccounts;
    }

    static void PrintBankAccounts(List<BankAccount> newBankAcccounts)
    {
        foreach (BankAccount account in newBankAcccounts.OrderByDescending(x => x.Balance).
            ThenBy(x => x.Bank.Length))
        {
            string bank = account.Bank;
            string name = account.AccountName;
            decimal balance = account.Balance;

            Console.WriteLine("{0} -> {1} ({2})", name, balance, bank);
        }
    }
}
class BankAccount
{
    public string Bank { get; set; }
    public string AccountName { get; set; }
    public decimal Balance { get; set; }
}