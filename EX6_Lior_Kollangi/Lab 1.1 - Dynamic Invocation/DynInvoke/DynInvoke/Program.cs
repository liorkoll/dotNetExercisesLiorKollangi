using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DynInvoke
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            Console.WriteLine(InvokeHello(a,"Lior"));
            Console.WriteLine(InvokeHello(b,"Alexender"));
            Console.WriteLine(InvokeHello(c, "Stass"));

        }
        public static string InvokeHello(object obj,string str)
        {
            MethodInfo methodInfo = obj.GetType().GetMethod("Hello",
                new Type[] { typeof(string) });
            return (string)methodInfo.Invoke(obj, new object[] { str });
        }
    }
}
