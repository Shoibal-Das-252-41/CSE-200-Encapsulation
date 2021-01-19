using System;

namespace Encapsulation
{
    class Account
    {
        int accountBalance = 858;

        public int Balance
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Negative Balance Value Not Allowed!");
                }
                else 
                {
                    accountBalance = value;
                }
            }
            get
            {
                return accountBalance;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            myAccount.Balance = 9759;
            Console.WriteLine("Your Account Balance is : " + myAccount.Balance);
            Console.ReadLine();
        }
    }
}
