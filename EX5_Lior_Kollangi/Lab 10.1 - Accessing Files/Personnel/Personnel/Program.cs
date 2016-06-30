using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    class Program
    {
        public static List<string> readFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            List<string> lines = new List<string>();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                lines.Add(line);

            }
            return lines;
        }

        public static void Main()
        {
            string path = @"c:\temp\text.txt";
            List<string> lines = readFile(path);
            
            foreach (string l in lines)
            {
                Console.WriteLine(l);
            }
        }
    }

}
