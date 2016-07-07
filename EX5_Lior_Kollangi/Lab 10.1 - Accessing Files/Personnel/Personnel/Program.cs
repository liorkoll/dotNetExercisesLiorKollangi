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
       

        public static void Main()
        {
            Personnel personnel = new Personnel();
            string path = "text.txt";
            List<string> lines = personnel.ReadFile(path);
            
            foreach (string l in lines)
            {
                Console.WriteLine(l);
            }
        }
    }

}
