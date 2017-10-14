using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {
        
        public CheckingAccount(double accountBalance)
        {
            this.accountBalance = accountBalance;
        }

        public override void AddBalance()
        {
            Console.WriteLine("How much would you like to add?");
            double.Parse(Console.ReadLine());
            newBalance = accountBalance += double.Parse(Console.ReadLine());
        }
        public override void DeductBalance()
        {
            Console.WriteLine("How much would you like to add?");
            double.Parse(Console.ReadLine());
            newBalance = accountBalance -= double.Parse(Console.ReadLine());
        }


    }
}
