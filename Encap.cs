
using System;

class Banks
{
    private double balance = 1000;

    public double GetBalance()
    {
        return balance;
    }

    public void Deposit(double amount)
    {
        if (amount >= 0)
        {
            balance = amount;
        }
        else
        {
            Console.WriteLine("Invalid Balance");
        }
    }
}

