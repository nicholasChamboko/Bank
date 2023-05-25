using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class BankAccount
    {
        //Encapsulation of properties using automatic properties
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }
        //Constructor
        public BankAccount(string accountNumber, string accountHolder, decimal initialBalance) 
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        //Made the method abstract so all derives classes can have their own implimentation of deposit
        public abstract void Deposit(decimal amount);

        public void Withdraw(decimal amount)
        {
            if(amount< Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawal of {amount} was made from your account: {AccountNumber}");
            }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Balance: {Balance}");
        }
    }
}
