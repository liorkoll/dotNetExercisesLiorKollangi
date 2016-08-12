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
            List<Job> jobs = new List<Job>();
           // Job job = new Job("MyJob",1);
           // job.AddProcessToJob(Process.Start("mspaint"));
           //job.AddProcessToJob(Process.Start("notepad"));
          
           //Console.WriteLine("press enter to exit");
           //Console.ReadLine();
           //job.Kill();
            try
            {
                for (int i = 1; i < 20; i++)
                {
                    var j = new Job(10485760);
                }
            }
            catch (ObjectDisposedException ex1)
            {
                Console.WriteLine(ex1.Message);

            }
            catch
                (InvalidOperationException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
      

            //var sw = new Stopwatch();
            //sw.Start();
            //Console.WriteLine(GC.GetTotalMemory(true));
            //    for (int i = 0; i < 20; i++)
            //    {
            //        Job job2 = new Job(10485760);
            //        //job2.AddProcessToJob(Process.Start("mspaint"));
            //        Console.WriteLine(GC.GetTotalMemory(true));
            //        jobs.Add(job2);
            //    }
            //    Console.WriteLine("press enter to exit");
            //    Console.ReadLine();
            //    foreach (Job j in jobs)
            //    {
            //        j.Kill();
            //    }


            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine(GC.GetTotalMemory(true));
            //Console.ReadLine();
            
        }
    }
}
