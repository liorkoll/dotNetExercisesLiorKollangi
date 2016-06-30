using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type some sentence");
            String s = Console.ReadLine();
            while (!String.IsNullOrEmpty(s))
            {
                string[] words = s.Split();
                Console.WriteLine("Number of words: " + words.Length);
                Array.Reverse(words);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("the reverse words: ");
                foreach (string str in words)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine("the sorted words: ");
                Array.Sort(words);
                foreach (string str in words)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Please type some sentence");
                s = Console.ReadLine();
            }
        }
   
    }
}
