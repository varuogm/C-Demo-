using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
 
            var account = new BankAccount("Gourav", 100);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");
 
            account.MakeWithdrawal(1000, DateTime.Now, "Rent payment/n");
            Console.WriteLine(account.Balance); // 9000 printed
 
            account.MakeDeposit(15000, DateTime.Now, "ITT fiest payment/n");
            Console.WriteLine(account.Balance); // 24000 printed
 
 
            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine("\n --------- *  ------------------ * ---------------- * ----------------- *  ---------- \n");
 
 
            /* 
                Date                    Amount             Balance              Note
                16 - 02 - 2022         10000                10000             Initial balance
                16 - 02 - 2022        - 1000               9000               Rent payment/ n
                16 - 02 - 2022         15000               24000              ITT fiest payment / n
            */
 
 
 
            // Test that the initial balances must be positive:
 
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException exceptionAgyaaa)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(exceptionAgyaaa.ToString());
 
            }
 
 
            // Test for a negative balance
 
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
                Console.WriteLine("Attempt to overdraw");
            }
 
            catch (InvalidOperationException exceptionAgyaaa)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(exceptionAgyaaa.ToString());
 
            }
        }
    }
}