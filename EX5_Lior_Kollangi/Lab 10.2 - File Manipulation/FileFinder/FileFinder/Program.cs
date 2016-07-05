using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                if (args.Length != 2)
                {
                    Console.WriteLine("2 arguments expected");
                    Environment.Exit(1);
                }
                List<string> listOfFilesContainsString = new List<string>();
                FinderFilterdFiles finder = new FinderFilterdFiles();
                finder.searchfiles(listOfFilesContainsString, args[0],args[1]);

                foreach (string file in listOfFilesContainsString)
                {
                    Console.WriteLine(file);
                }
            }

        }
    }
    }