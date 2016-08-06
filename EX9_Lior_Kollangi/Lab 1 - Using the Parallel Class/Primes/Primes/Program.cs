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
           
            ParallelOptions options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = maximum
            };

            Parallel.For(firstNumber, lastNumber+1,options, i =>
            {
                int limit = (int)Math.Sqrt(i);
                bool prime = true;
                for (int j = 2; j <=limit; j++)
                
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
            Console.WriteLine("testing with deg 1");
            var sw=Stopwatch.StartNew();
            var c = CalcPrimes(2, 10000, 1);          
            Console.WriteLine(sw.Elapsed);
            sw.Restart();
            Console.WriteLine("testing with deg 10");
            c =CalcPrimes(1, 10000, 10);
            Console.WriteLine(sw.Elapsed);

        }
    }
}
