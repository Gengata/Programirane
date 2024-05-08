using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_04
{
    internal class BankAcc
    {
        private int id;
        private double balance;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(double amount)
        {
            this.balance += double.Parse(Console.ReadLine());
        }
        public void Withdraw(double amount) 
        {
            this.balance -= double.Parse(Console.ReadLine());   
        }
        public override string ToString()
        {
            return $"Account {this.id}, balance {this.balance}";
        }

    }
}
