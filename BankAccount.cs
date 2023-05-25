using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
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

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposit of {amount} was made into your account: {AccountNumber}");
        }

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
