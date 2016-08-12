using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Jobs {
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            using (Job job = new Job("MyJob", 10485760)) 
            {
                for (int i = 0; i < 20; i++)
                {
                    Process p = Process.Start("mspaint");
                    job.AddProcessToJob(p);

                }
               
                Console.WriteLine("Press enter to kill all notepad processs ");
                Console.ReadLine();
                job.Kill();
               
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            
        }
    }
}
