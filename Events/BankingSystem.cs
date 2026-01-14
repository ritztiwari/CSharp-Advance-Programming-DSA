//Banking System

//When withdrawal happens
//Check balance
//Log transaction
//Send SMS
//(Use delegates/events)

using System;
using System.Collections.Generic;


class Account
{
    public int AccountNumber { get; }
    public double Balance { get; private set; }

    public Account(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
    }
}

class WithdrawalEventArgs : EventArgs
{
    public Account Account { get; }
    public double Amount { get; }

    public WithdrawalEventArgs(Account account, double amount)
    {
        Account = account;
        Amount = amount;
    }
}

class BankingSystem
{
    private List<Account> accounts = new List<Account>();

    public event EventHandler<WithdrawalEventArgs> WithdrawalOccurred;

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public void Withdraw(Account account, double amount)
    {
        if (account.Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }

        account.Withdraw(amount);
        OnWithdrawalOccurred(account, amount);
    }

    protected virtual void OnWithdrawalOccurred(Account account, double amount)
    {
        WithdrawalOccurred?.Invoke(this, new WithdrawalEventArgs(account, amount));
    }

    // Business Actions
    public void CheckBalance(Account a)
    {
        Console.WriteLine($"Balance after withdrawal: {a.Balance}");
    }

    public void LogTransaction(Account a, double amount)
    {
        Console.WriteLine($"Transaction logged: {amount} withdrawn from Account {a.AccountNumber}");
    }

    public void SendSMS(Account a, double amount)
    {
        Console.WriteLine($"SMS: {amount} withdrawn from your account {a.AccountNumber}");
    }
}

