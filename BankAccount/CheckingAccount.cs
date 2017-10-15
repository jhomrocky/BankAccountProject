using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {
        
        public CheckingAccount(double checkingAccountBalance, int accountNumber)
        {
            this.checkingAccountBalance = checkingAccountBalance;
            this.accountNumber = accountNumber;
        }

        public override void AddBalance()
        {
            Console.WriteLine("How much would you like to add?");
            checkingAccountBalance = (checkingAccountBalance + double.Parse(Console.ReadLine()));
            Console.WriteLine("Your new balance is: " + checkingAccountBalance);
        }
        public override void DeductBalance()
        {
            Console.WriteLine("How much would you like to add?");
            checkingAccountBalance = (checkingAccountBalance - double.Parse(Console.ReadLine()));
            Console.WriteLine("Your new balance is: " + checkingAccountBalance);
        }


    }
}
