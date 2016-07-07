using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttribDemo
{
    class Program
    {
        public bool AnalayzeAssembly(Assembly assembly)
        {
            foreach(Type t in assembly.GetTypes())
            {
                bool isAllAproved = true;
                object[] attributs = t.GetCustomAttributes(typeof(CodeReviewAttribute), false);
                Console.WriteLine("Type name {0}  Attribute length {1}", t.Name, attributs.Length);
                foreach (CodeReviewAttribute cra in attributs)
                {
                    Console.WriteLine("Name: {0}, Date: {1}, Approved: {2}",
                    cra.ReviewerName, cra.ReviewerDate.ToShortDateString(), cra.Approved);
                    if (cra.Approved == false)
                    {
                       isAllAproved =  false;
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.WriteLine(prog.AnalayzeAssembly(Assembly.GetExecutingAssembly()));

        }
        }
    
    
}
