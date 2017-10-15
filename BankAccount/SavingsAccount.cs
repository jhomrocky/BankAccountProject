using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {

        private double minimumBalance;

        public SavingsAccount(double savingsAccountBalance, int accountNumber)
        {
            this.savingsAccountBalance = savingsAccountBalance;
            this.accountNumber = accountNumber;
            this.minimumBalance = 0.0d;
        }

        public override void AddBalance()
        {
            Console.WriteLine("How much would you like to add?");
            savingsAccountBalance = (savingsAccountBalance + double.Parse(Console.ReadLine()));
            Console.WriteLine("Your new balance is: " + savingsAccountBalance);
        }
        public override void DeductBalance()
        {
            Console.WriteLine("How much would you like to deduct?");
            savingsAccountBalance = (savingsAccountBalance - double.Parse(Console.ReadLine()));
                if (savingsAccountBalance < minimumBalance)
                {
                Console.WriteLine("You cannot go below $0 in your savings. Please enter a new amount.");
                double.Parse(Console.ReadLine());
                }
                else
                {
                Console.WriteLine("Your new balance is: " + savingsAccountBalance);
                }

            Console.WriteLine("Your new balance is: " + savingsAccountBalance);
        }
    }
}
