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

            Client Daniel = new Client("Daniel", "Platinum", "867-5309");
            SavingsAccount savAccount = new SavingsAccount(500.0d, 123456);
            CheckingAccount checkAccount = new CheckingAccount(1000.0d, 654321);


            //User input setup
            string choiceOne = "1. View Client Information";
            string choiceTwo = "2. View Account Balance";
            string choiceThree = "3. Deposit Funds ";
            string choiceFour = "4. Withdraw Funds";
            string choiceFive = "5. Exit";

            Console.WriteLine("Welcome to your personal bank account manager!");
            Console.WriteLine("Please choose from the choices below by picking a number:");

            //Start for goto loop to return back here
            Start:
            Console.WriteLine(choiceOne);
            Console.WriteLine(choiceTwo);
            Console.WriteLine(choiceThree);
            Console.WriteLine(choiceFour);
            Console.WriteLine(choiceFive);
            string userChoice = Console.ReadLine();

            //User input result/action

            //Client info
            while (userChoice == "1" || userChoice == "1.")
            {
                Daniel.DisplayInformation();
                Console.WriteLine("Would you like to do something else? (Yes/No)");
                if (Console.ReadLine().ToUpper() == "YES")
                {
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Thank you for banking with WCCI Bank!");
                    Environment.Exit(0);
                }
            }

            //Account Balance
            while (userChoice == "2" || userChoice == "2.")
            {
                Console.WriteLine("Which account balance would you like to view?");
                Console.WriteLine("1. Checking Account");
                Console.WriteLine("2. Savings Account");
                string subChoice = Console.ReadLine();
                if (subChoice == "1" || subChoice == "1.")
                {
                    Console.WriteLine("Your checking account contains: " + checkAccount.checkingAccountBalance + ".");
                    Console.WriteLine("Would you like to do something else? (Yes/No)");
                    if (Console.ReadLine().ToUpper() == "YES")
                    {
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thank you for banking with WCCI Bank!");
                        Environment.Exit(0);
                    }
                }
                else if (subChoice == "2" || subChoice == "2.")
                {
                    Console.WriteLine("Your savings account contains: " + savAccount.savingsAccountBalance + ".");
                    Console.WriteLine("Would you like to do something else? (Yes/No)");
                    if (Console.ReadLine().ToUpper() == "YES")
                    {
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thank you for banking with WCCI Bank!");
                        Environment.Exit(0);
                    }
                }

            }

            //Deposit money
            while (userChoice == "3" || userChoice == "3.")
            {
                Console.WriteLine("Deposit to which account?");
                Console.WriteLine("1. Checking Account");
                Console.WriteLine("2. Savings Account");
                string subChoice = Console.ReadLine();
                if (subChoice == "1" || subChoice == "1.")
                {
                    checkAccount.AddBalance();
                    Console.WriteLine("Would you like to do something else? (Yes/No)");
                    if (Console.ReadLine().ToUpper() == "YES")
                    {
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thank you for banking with WCCI Bank!");
                        Environment.Exit(0);
                    }
                }
                else if (subChoice == "2" || subChoice == "2.")
                {
                    savAccount.AddBalance();
                    Console.WriteLine("Would you like to do something else? (Yes/No)");
                    if (Console.ReadLine().ToUpper() == "YES")
                    {
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thank you for banking with WCCI Bank!");
                        Environment.Exit(0);
                    }
                }
                else if (subChoice.ToUpper() == "EXIT")
                {
                    Console.WriteLine("Thank you for banking with WCCI Bank!");
                    Environment.Exit(0);
                }

            }

            //Withdraw money
            while (userChoice == "4" || userChoice == "4.")
            {
                Console.WriteLine("Withdraw from which account?");
                Console.WriteLine("1. Checking Account");
                Console.WriteLine("2. Savings Account");
                string subChoice = Console.ReadLine();
                while (subChoice == "1" || subChoice == "1.")
                {
                    checkAccount.DeductBalance();
                    Console.WriteLine("Would you like to do something else? (Yes/No)");
                    if (Console.ReadLine().ToUpper() == "YES")
                    {
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thank you for banking with WCCI Bank!");
                        Environment.Exit(0);
                    }
                }
                while (subChoice == "2" || subChoice == "2.")
                {
                    savAccount.DeductBalance();
                    Console.WriteLine("Would you like to do something else? (Yes/No)");
                    if (Console.ReadLine().ToUpper() == "YES")
                    {
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thank you for banking with WCCI Bank!");
                        Environment.Exit(0);
                    }
                }
                while (subChoice.ToUpper() == "EXIT")
                {
                    Console.WriteLine("Thank you for banking with WCCI Bank!");
                    Environment.Exit(0);
                }
            }

            //Exit
            while (userChoice == "5" || userChoice == "5." || userChoice.ToUpper() == "EXIT")
            {
                Console.WriteLine("Thank you for banking with WCCI Bank!");
                Environment.Exit(0);
            }
        }

    }
}
