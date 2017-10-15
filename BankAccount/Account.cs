using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Account
    {
        //Account setup
        protected int accountNumber;
        protected string accountType;
        public double savingsAccountBalance;
        public double checkingAccountBalance;

        public int AccountNumber
        {
            get { return this.accountNumber; }
        }
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        //Constructor
        public Account()
        {

        }
        public Account (int accountNumber, double savingsAccountBalance, double checkingAccountBalance, string accountType)
        {
            this.accountNumber = accountNumber;
            this.savingsAccountBalance = savingsAccountBalance;
            this.checkingAccountBalance = checkingAccountBalance;
            this.accountType = accountType;
        }

        //Abstract Methods
        public abstract void AddBalance();
        public abstract void DeductBalance();

    }
}
