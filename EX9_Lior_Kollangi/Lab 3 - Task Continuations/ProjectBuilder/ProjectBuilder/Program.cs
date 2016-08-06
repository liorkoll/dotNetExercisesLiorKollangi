using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectBuilder project = new ProjectBuilder();
            Console.WriteLine("No Parallel build");
            project.BuildParallel();
            Console.WriteLine("**************************");
            Console.WriteLine("Parallel build");
            project.BuildWithoutParallel();
        }
       


    }
}
