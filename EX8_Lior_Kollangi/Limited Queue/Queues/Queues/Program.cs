using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            LimitedQueue<int> myQueue = new LimitedQueue<int>(100);

            {
                for (int i = 0; i < 1000; i++)
                {
                    if (i % 3 == 0)
                    {
                        ThreadPool.QueueUserWorkItem((o) => myQueue.Dequeue(), null);
                    }
                    else
                    {
                        ThreadPool.QueueUserWorkItem((o) => myQueue.Enqueue(new Random().Next()), null);
                    }

                }
                Console.ReadLine();
            }

        }




        
    }
}
