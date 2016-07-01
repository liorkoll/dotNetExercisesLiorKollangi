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
            string path = args[0];
            string filterName = args[1];
            DirectoryInfo di = new DirectoryInfo(path);
            List<string> filterList = new List<string>();
            FileInfo[] fiArr = di.GetFiles();
            foreach (FileInfo f in fiArr)
            {
                if (f.Name.Contains(filterName))
                {
                    filterList.Add(string.Format("File Name : {0} size : {1} bytes.", f.Name, f.Length));
                }
            }
            foreach(string s in filterList)
            {
                Console.WriteLine(s);
            }
        }   
        }
    }