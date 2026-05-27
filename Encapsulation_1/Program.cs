using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_1
{
    class Account
    {
        public double balance;
        public void Deposit(double  amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Deposite Amount is 5000:");
            }
        }
        public void Withdraw(double amount)
        {
            if(amount <= balance )
            {
                balance -= amount;
                Console.WriteLine("Deposite Withdraw Amount  2000:");
            }
        }
        public double GetBalance()
        {
            return balance;
        }
        
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.Deposit(5000);
            acc.Withdraw(2000);
            Console.WriteLine("Balance " +  acc.GetBalance());
            Console.ReadLine();
        }
    }
}
