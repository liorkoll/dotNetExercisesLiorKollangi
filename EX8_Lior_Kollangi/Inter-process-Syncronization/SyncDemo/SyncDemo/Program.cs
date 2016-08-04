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
             for (int i = 0; i < 10000; i++)
            {
               mutex.WaitOne();
                StreamWriter writer = new StreamWriter(@"data1.txt", true);
                writer.WriteLine("Writing to Process " + Process.GetCurrentProcess().Id);
                Console.WriteLine("Process ID: {0}", Process.GetCurrentProcess().Id);
                writer.Close();
                mutex.ReleaseMutex();
            }
            Console.ReadLine();
        }

    }
}
    