using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public BankAccount()
        {
        }

        public void Deposit(double depositAmount)
        {
            balance += depositAmount;
            Console.WriteLine($"{depositAmount} has been deposited into your account.");
        
        }

        public void GetBalance()
        {
            Console.WriteLine($"${balance}");
        }
    }
}
