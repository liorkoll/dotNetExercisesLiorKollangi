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
            Random rand = new Random();
            Parallel.For(firstNumber, lastNumber+1, (i,state) =>
            {
                lock (rand)
                {
                    if (rand.Next(10000000) == 0)
                    {
                        state.Stop();
                        return;
                    }
                }
                int limit = (int)Math.Sqrt(i);
                bool prime = true;
                for (int j = 2; j <= limit; j++)
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                    if (prime)
                    
                        lock (primes)
                            primes.Add(i);
                     
                                    
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
