using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_04
{
    internal class BankAcc
    {
        private int id;
        private double balance;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public double Balance
        {
            get { return this.Balance; }
            set { this.Balance = value; }
        }
        public void Deposit(double amount)
        {
        this.balance += amount;
        }
        public void Withdraw(double amount)
         {
            this.balance -= amount;
         }
        public override string ToString()
        {
            return $"Account {this.Id} balance{this.balance}";
        }



    }
}
