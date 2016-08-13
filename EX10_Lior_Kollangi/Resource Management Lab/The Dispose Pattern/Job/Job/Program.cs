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

            Console.WriteLine("Part A example:");
            Console.WriteLine("**************************************************");
            try
            {
                Job job = new Job("MyJob");
                job.AddProcessToJob(Process.Start("mspaint"));
                job.AddProcessToJob(Process.Start("notepad"));

                Console.WriteLine("press enter to exit");
                Console.ReadLine();

                job.Kill();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Part B example:");
            Console.WriteLine("**************************************************");

            try
            {
                for (int i = 0; i < 20; i++)
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
        }
    }
}
