using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        private string clientName;
        private int accountNumber;
        private string accountLevel;
        

        public Client(string clientName, int accountNumber, string accountLevel)
        {
            this.clientName = clientName;
            this.accountNumber = accountNumber;
            this.accountLevel = accountLevel;
        }

        public virtual void DisplayInformation()
        {
            Console.WriteLine("Name: " + clientName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Level: " + accountLevel);
        }
    }
}
