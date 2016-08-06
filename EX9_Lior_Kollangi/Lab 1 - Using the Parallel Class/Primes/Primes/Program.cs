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
        public static List<int> CalcPrimes(int firstNumber, int lastNumber, int maximum)
        {
            List<int> primes = new List<int>();
            int count = 0;
            ParallelOptions options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = maximum
            };

            Parallel.For(firstNumber, lastNumber,options, i =>
            {
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
            var sw=Stopwatch.StartNew();
            CalcPrimes(1, 10000, 1);
            Console.WriteLine(sw.Elapsed);
            sw.Restart();         
            CalcPrimes(1, 10000, 10);
            Console.WriteLine(sw.Elapsed);

        }
    }
}
