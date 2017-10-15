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

        //Add Balance
        public override void AddBalance()
        {
            Console.WriteLine("How much would you like to add?");
            savingsAccountBalance = (savingsAccountBalance + double.Parse(Console.ReadLine()));
            Console.WriteLine("Your new balance is: " + savingsAccountBalance);
        }

        //Deduct Balance
        public override void DeductBalance()
        {

            Console.WriteLine("How much would you like to deduct?");
            var deductAmount = double.Parse(Console.ReadLine());
            while (savingsAccountBalance - deductAmount < minimumBalance)
            {
                Console.WriteLine("You cannot go below $0 in your savings. Please enter a new amount.");
                deductAmount = double.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Your new balance is: " + (savingsAccountBalance - deductAmount));
            savingsAccountBalance -= deductAmount;
        }
    }
}
