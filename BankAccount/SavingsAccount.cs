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

        public SavingsAccount(double accountBalance)
        {
            this.accountBalance = accountBalance;
            this.minimumBalance = 0.0d;
        }

        public override void AddBalance()
        {
            Console.WriteLine("How much would you like to add?");
            double.Parse(Console.ReadLine());
            newBalance = accountBalance += double.Parse(Console.ReadLine());
        }
        public override void DeductBalance()
        {
            Console.WriteLine("How much would you like to deduct?");
            double.Parse(Console.ReadLine());
            newBalance = accountBalance -= double.Parse(Console.ReadLine());
                while (minimumBalance < 0)
                {
                Console.WriteLine("You cannot go below $0 in your savings. Please enter a new amount.");
                double.Parse(Console.ReadLine());
                }
        }
    }
}
