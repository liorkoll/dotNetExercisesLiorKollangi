﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class Program
    {
        public static int[] CalcPrimes(int x,int y)
        {
            int count = 0;
            ArrayList list = new ArrayList();

            for (int i = x; i < y; i++)
            {
                for (int j = 1; j < y; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    list.Add(i);
                }
                count = 0;
            }
            int[] ans = new int[list.Count];
            list.CopyTo(ans);
            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start value");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end value");
            int b = int.Parse(Console.ReadLine());
            int[] ans = CalcPrimes(a, b);
            Console.WriteLine("-------------------------");
            Console.WriteLine("prime numbers: ");
            foreach (int val in ans)
            {
                Console.WriteLine(val);
            }

        }
    }
}
