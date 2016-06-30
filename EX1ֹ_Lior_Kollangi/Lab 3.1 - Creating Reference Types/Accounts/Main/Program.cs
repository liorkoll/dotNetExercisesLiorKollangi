using AccountsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = AccountFactory.CreateAccount(100);
            Console.WriteLine("acc1= "+acc1.Balance);
            acc1.Deposit(10);
            Console.WriteLine("acc1= "+acc1.Balance);
            acc1.Withdraw(20);
            Console.WriteLine("acc1= "+acc1.Balance);         
            Account acc2 = AccountFactory.CreateAccount(130);
            Console.WriteLine("acc2= "+acc2.Balance);
            acc2.Transfer(acc1, 50);
            Console.WriteLine("acc2 after transfer from acc2 "+acc1.Balance);
            Console.WriteLine("acc1 after transfring from acc2"+acc2.Balance);
            Console.WriteLine(acc1.ID);
            Console.WriteLine(acc2.ID);


        }
    }
}
