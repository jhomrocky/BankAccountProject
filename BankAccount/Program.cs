using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object substantiating

            Client Daniel = new Client("Daniel", 123456, "Platinum");
            SavingsAccount savAccount = new SavingsAccount(500.0d);
            CheckingAccount checkAccount = new CheckingAccount(1000.0d);


            //User input setup
            string choiceOne = "1. View Client Information";
            string choiceTwo = "2. View Account Balance";
            string choiceThree = "3. Deposit Funds ";
            string choiceFour = "4. Withdraw Funds";
            string choiceFive = "5. Exit";


            Console.WriteLine("Welcome to your personal bank account manager!");
            Console.WriteLine("Please choose from the choices below by picking a number:");
            Console.WriteLine(choiceOne);
            Console.WriteLine(choiceTwo);
            Console.WriteLine(choiceThree);
            Console.WriteLine(choiceFour);
            Console.WriteLine(choiceFive);
            string userChoice = Console.ReadLine();

            //User input result/action

            if (userChoice == "1" || userChoice == "1.") //Client Info
            {
                //Account Savings = new SavingsAccount();
            }
            else if (userChoice == "2" || userChoice == "3.") //Account Balance
            {
                //Account Checking = new CheckingAccount();
            }
            else if (userChoice == "3" || userChoice == "3.") //Deposit
            {
                Console.WriteLine("Deposit to which account?");
                Console.WriteLine("1. Checking Account");
                Console.WriteLine("2. Savings Account");
                Console.ReadLine();
                string subChoice = Console.ReadLine();
                if (subChoice == "1" || subChoice == "1.")
                {
                    
                }
                else if (subChoice == "2" || subChoice == "2.")
                {

                }
                else if (subChoice.ToUpper() == "EXIT")
                {
                    Console.WriteLine("Thank you for banking with WCCI Bank!");
                    Environment.Exit(0);
                }

            }
            else if (userChoice == "4" || userChoice == "4.") //Withdraw
            {
                Console.WriteLine("Withdraw from which account?");
                Console.WriteLine("1. Checking Account");
                Console.WriteLine("2. Savings Account");
                Console.ReadLine();
                string subChoice = Console.ReadLine();
                if (subChoice == "1" || subChoice == "1.")
                {

                }
                else if (subChoice == "2" || subChoice == "2.")
                {

                }
                else if (subChoice.ToUpper() == "EXIT")
                {
                    Console.WriteLine("Thank you for banking with WCCI Bank!");
                    Environment.Exit(0);
                }
            }
            else if (userChoice == "5" || userChoice == "5.") //Exit
            {
                Console.WriteLine("Thank you for banking with WCCI Bank!");
                Environment.Exit(0);
            }
        }

    }
}
