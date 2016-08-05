using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAwaiter
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomAwaiter ca = new CustomAwaiter();
            ca.RunAsync().Wait();
        }
        


    }
}
