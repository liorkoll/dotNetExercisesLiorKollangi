using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLib
{
    public static class AccountFactory
    {
        static int ID=1;
        public static Account CreateAccount(decimal balance)
        {
            Account acc = new Account(ID);
            acc.Deposit(balance);
            ID++;
            return acc;
        }
    }
}
