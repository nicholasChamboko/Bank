using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string accountNumber, string accountHolder, decimal initialBalance, decimal interestRate) 
            : base(accountNumber, accountHolder,initialBalance)
        {
            InterestRate = interestRate;
        }
        public override void Deposit(decimal amount)
        {
            //Applying Interest before depositing
            decimal interestAmount = Balance * InterestRate / 100;
            Balance += interestAmount;
            base.Deposit(amount);
        }
    }
}
