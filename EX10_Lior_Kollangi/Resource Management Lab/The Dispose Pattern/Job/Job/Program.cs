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
            using (Job job = new Job())
            {
                for (int i = 0; i < 20; i++)
                {
                    Process p = Process.Start("notepad");
                    job.AddProcessToJob(p);

                }




                Console.WriteLine("Press <Enter> to kill all notepad instances...");
                Console.ReadLine();
                job.Kill();
            }
        }
    }
}
