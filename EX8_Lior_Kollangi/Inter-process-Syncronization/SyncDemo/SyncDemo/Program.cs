using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex mutex = new Mutex(false, "SyncFileMutex");
            StreamWriter writer = new StreamWriter(@"data.txt",true);
            for(int i = 0; i < 1000; i++)
            {
                mutex.WaitOne();
                writer.Write("Proceess Id:{0}",Process.GetCurrentProcess().Id);
                mutex.ReleaseMutex();
            }
            Console.ReadLine();
        }
    }
}
