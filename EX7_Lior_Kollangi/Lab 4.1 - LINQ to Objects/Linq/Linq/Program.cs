﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = from t in typeof(string).Assembly.GetExportedTypes()
                                where t.IsInterface
                                orderby t.Name
                                select new
                                {
                                    name = t.Name,
                                    numOfMethods = t.GetMethods().Length
                                };

            Console.WriteLine("public interfaces in mscrorlib assembly");
            Console.WriteLine("----------------------------------------");
            foreach (var type in types)
                Console.WriteLine(type);
            Console.WriteLine("-------------------------------------------------");

            var processes = from p in Process.GetProcesses()
                            where p.Threads.Count < 5 && p.CanAccess()
            orderby p.Id
                            select new
                            {
                                name = p.ProcessName,
                                id = p.Id,
                                startTime = p.StartTime
                            };

            Console.WriteLine("processes running on your pc");
            Console.WriteLine("-------------------------------------------------");

            foreach (var process in processes)
                Console.WriteLine(process);
           
            var processesPriority = from p in Process.GetProcesses()
                                    where p.Threads.Count < 5
                                    orderby p.Id
                                    group new
                                    {
                                        name = p.ProcessName,
                                        id = p.Id,
                                        startTime = p.StartTime
                                    } by p.BasePriority
                                    into g
                                    orderby g.Key
                                    select g;
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("processes running on your pc grouping by their base priority");
            Console.WriteLine("------------------------------------------------------------");

            foreach (var process in processes)
                Console.WriteLine(process);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("total number of threads in the system:{0}", Process.GetProcesses().Sum(
                p => p.Threads.Count));
        }













    }
}
