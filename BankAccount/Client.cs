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
        private string accountLevel;
        private string phoneNumber;
        
        public Client()
        {

        }
        public Client(string clientName, string accountLevel, string phoneNumber)
        {
            this.clientName = clientName;
            this.accountLevel = accountLevel;
            this.phoneNumber = phoneNumber;
        }

        public virtual void DisplayInformation()
        {
            Console.WriteLine("Name: " + clientName);
            Console.WriteLine("Account Level: " + accountLevel);
        }
    }
}
