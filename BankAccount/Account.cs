using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Account
    {
/// <summary>
/// 
/// </summary>
        public int accountNumber;
        protected double accountBalance;
        protected string accountType;
        protected double newBalance;

        public int AccountNumber
        {
            get { return this.accountNumber; }
        }
        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public Account()
        {

        }
        public Account (int accountNumber, double accountBalance, string accountType)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.accountType = accountType;
        }

        public virtual void AddBalance()
        {
            accountBalance = newBalance;
        }
        public virtual void DeductBalance()
        {
            accountBalance = newBalance;
        }

    }
}
