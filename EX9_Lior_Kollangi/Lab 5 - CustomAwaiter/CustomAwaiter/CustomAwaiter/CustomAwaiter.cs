using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAwaiter
{
    class CustomAwaiter
    {

        public async Task RunAsync()
        {



            Console.WriteLine("await for 2 seconds");
            await TimeSpan.FromSeconds(2);

            Console.WriteLine("await for 2 seconds");
            await 2000;

            Console.WriteLine("Starting cmd and awaiting until its closed");
            await Process.Start("cmd");


            Console.WriteLine("{0} - Done", DateTime.Now);
        }
    }
}
