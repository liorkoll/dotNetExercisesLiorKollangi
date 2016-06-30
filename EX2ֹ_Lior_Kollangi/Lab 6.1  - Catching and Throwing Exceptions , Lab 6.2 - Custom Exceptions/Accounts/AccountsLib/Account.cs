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
            if (amount < 0) {
                throw new ArgumentOutOfRangeException("can't deposit Amount is not postive");
                    }
            else {
                this.balance += amount;
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("can't withdraw Amount is not postive");
            }
            else
            {
                if (balance >= amount)
                {
                    balance -= amount;
                }

                else {
                    throw new InsufficientFundsException("can't withdraw amount that cause negative balance");
                }
            }
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
        }
        public void Transfer(Account acc, decimal amount)
        {
            Console.WriteLine("before transfer:" + this.balance);
            try
            {
                this.Withdraw(amount);
                acc.Deposit(amount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("can't transfer:"+e.Message);
            }
            finally
            {
                Console.WriteLine("transfer attempt has been made");
                Console.WriteLine("after transfer:" + this.balance);

            }

        }

        }
}