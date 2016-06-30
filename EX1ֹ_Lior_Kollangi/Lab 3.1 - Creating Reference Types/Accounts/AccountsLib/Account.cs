using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLib
{
    public class Account
    {
        private int accoundId;
        private decimal balance;
        internal Account(int accoundId)
        {
            this.accoundId = accoundId;
        }
       public int ID
        {
            get
            {
                return this.accoundId;
            }
        }
    

        public void Deposit(decimal amount)
        {

            this.balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
                balance -= amount;
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
        }
        public void Transfer(Account acc,decimal amount)
        {
            this.Withdraw(amount);
            acc.Deposit(amount);            
        }
       


    }
}