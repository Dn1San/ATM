using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountClass account1 = new AccountClass();

            while (true) {
                Console.WriteLine("Please enter account id:");
                int accountId = Console.ReadLine();
                if (accountId == account1.accountId)
                {
                    Console.WriteLine("Account Holder's Name: " + account1.accountHolderName);
                    Console.WriteLine("Account Balance: " + account1.accountBalance);
                }
                else
                {
                    Console.WriteLine("Sorry! please enter a correct account id.")
                }
            }
        }
    }
}
