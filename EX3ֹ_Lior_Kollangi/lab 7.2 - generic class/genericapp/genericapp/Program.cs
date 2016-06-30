using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    class Program
    {
        static void Main(string[] args)
        {            
             MultiDictionary<int, string> md = new  MultiDictionary<int, string>();
            md.Add(1, "one");
            md.Add(2, "two");
            md.Add(3, "three");
            md.Add( 1, "ich");
            md.Add( 2, "nee");
            md.Add(3, "sun");
            Console.WriteLine("*******************************");
            Console.WriteLine("checking IEnumerable: ");
            foreach (var val in (IEnumerable)md)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("*******************************");
            Console.WriteLine("your multiDictionary size: "+md.Count);
            Console.WriteLine("*******************************");
            Console.WriteLine("remove key 1");
            md.Remove(1);
            Console.WriteLine("*******************************");

            Console.WriteLine("your multiDictionary size after: " + md.Count);
            Console.WriteLine("*******************************");
            Console.WriteLine("checking IEnumerable: ");
            foreach (var val in (IEnumerable)md)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("*******************************");
            Console.WriteLine("remove (2,two)");
            md.Remove(2,"two");
            Console.WriteLine("your multiDictionary size after: " + md.Count);
            Console.WriteLine("*******************************");
            Console.WriteLine("checking IEnumerable: ");
            foreach (var val in (IEnumerable)md)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("*******************************");

            Console.WriteLine("try to remove value that not exits return: "+md.Remove(3, "kkkk"));
            Console.WriteLine("*******************************");
            Console.WriteLine("checking contains (4,four) return "+ md.Contains(4, "four"));
            Console.WriteLine("*******************************");
            Console.WriteLine("checking contains (3,three) return " + md.Contains(3, "three"));
            Console.WriteLine("*******************************");
            Console.WriteLine("checking contains (4) return " + md.ContainsKey(4));
            Console.WriteLine("*******************************");
            Console.WriteLine("checking contains (3) return " + md.ContainsKey(3));
            Console.WriteLine("*******************************");
            Console.WriteLine("your values: ");
            var values = md.Values;
            foreach (var val in (values))
            {
                Console.WriteLine(val);
            }        
            Console.WriteLine("*******************************");
            Console.WriteLine("your keys: ");
            var keys = md.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("*******************************");
            Console.WriteLine("clear : ");
            md.Clear();
            Console.WriteLine("your multiDictionary size after: " + md.Count);
            Console.WriteLine("*******************************");

        }
    }
}
