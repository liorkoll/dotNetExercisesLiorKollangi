﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            for(int i=0;i< num; i++)
            {
                for(int j=0;j<= i; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine("");
            }


        }
    }
}
