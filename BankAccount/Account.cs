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

        public virtual void AddBalance()
        {
            
        }
        public virtual void DeductBalance()
        {
            
        }

    }
}
