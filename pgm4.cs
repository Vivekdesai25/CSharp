using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string msg) : base(msg) { }
}

class BankAccount
{
    public double Balance { get; private set; }

    public BankAccount(double amount)
    {
        Balance = amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
            throw new InsufficientBalanceException("Insufficient Balance!");

        Balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount(5000);

        try
        {
            acc.Withdraw(7000);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

