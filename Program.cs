
using System;

class Bank
{
    static void Hii()
    {
        decimal balance = 1000;
        int choice;

        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.WriteLine("4. Exit");

        Console.Write("Enter your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Balance: Rs. " + balance);
        }
        else if (choice == 2)
        {
            Console.Write("Enter deposit amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine("Deposit successful!");
                Console.WriteLine("Balance: Rs. " + balance);
            }
            else
            {
                Console.WriteLine("Enter a valid amount.");
            }
        }
        else if (choice == 3)
        {
            Console.Write("Enter withdrawal amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (amount > 0 && amount <= balance)
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawal successful!");
                Console.WriteLine("Balance: Rs. " + balance);
            }
            else
            {
                Console.WriteLine("Invalid amount or insufficient balance.");
            }
        }
        else if (choice == 4)
        {
            Console.WriteLine("Thank you for visiting our bank!");
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }
}
