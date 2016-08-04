using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class Program
    {
        public static List<int> CalcPrimes(int firstNumber, int lastNumber)
        {
            List<int> primes = new List<int>(1024);
            int count = 0;
            Random rand = new Random();
            Parallel.For(firstNumber, lastNumber, (i,state) =>
            {
                lock (rand)
                {
                    if (rand.Next(10000000) == 0)
                    {
                        state.Stop();
                        return;
                    }
                }
                for (int j = 1; j < lastNumber; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                    if (count == 2)
                    {
                        lock (primes)
                            primes.Add(i);
                    }
                }
            });

                return primes;

            }   

        static void Main(string[] args)
        {
            var ans = CalcPrimes(3, 30000000);
            Console.WriteLine("returned : {0} numbers", ans.Count());
           
        }
    }
}
