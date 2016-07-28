using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Queues
{
    public class LimitedQueue<T>
    {
        private Queue<T> queue;
        private Semaphore semaphore;
        private object lockObj;
        public LimitedQueue(int size)
        {
            if (size < 1)
            {
                throw new ArgumentException("Invalid size");
            }
            semaphore = new Semaphore(size, size);
            queue = new Queue<T>();
            lockObj = new object();
        }
        public int Count { get
            {
                return queue.Count;
            }
        }
     
        public void Enqueue(T value)
            
        {
            semaphore.WaitOne();
            lock (lockObj)
            {
                queue.Enqueue(value);
            }
           
        }
        public T Dequeue()
        {
            T value;
            lock (lockObj)
            {
                value = queue.Dequeue();
                semaphore.Release();
            }
            return value;

        }
    }
}
