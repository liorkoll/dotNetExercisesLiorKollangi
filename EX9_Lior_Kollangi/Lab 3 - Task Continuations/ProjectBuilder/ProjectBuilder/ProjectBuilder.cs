using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectBuilder
{
    class ProjectBuilder
    {
        public void BuildProject(int number)
        {
            Console.WriteLine("Building project #{0}", number);
            Thread.Sleep(1000);
            Console.WriteLine("finish project #{0}", number);
        }

        public void BuildParallel()
        {
            Task t1 = Task.Factory.StartNew(() => BuildProject(1));
            Task t2 = Task.Factory.StartNew(() => BuildProject(2));
            Task t3 = Task.Factory.StartNew(() => BuildProject(3));
            Task t4 = t1.ContinueWith(_ => BuildProject(4));
            Task t5 = Task.Factory.ContinueWhenAll(new Task[] { t1, t2, t3 }, _ => BuildProject(5));
            Task t6 = Task.Factory.ContinueWhenAll(new Task[] { t3, t4 }, _ => BuildProject(6));
            Task t7 = Task.Factory.ContinueWhenAll(new Task[] { t5, t6 }, _ => BuildProject(7));
            Task t8 = t5.ContinueWith(_ => BuildProject(8));
            Task.WaitAll(t7, t8);
        }

        public void BuildWithoutParallel()
        {
            BuildProject(1);
            BuildProject(2);
            BuildProject(3);
            BuildProject(4);
            BuildProject(5);
            BuildProject(6);
            BuildProject(7);
            BuildProject(8);
        }


    }
}
