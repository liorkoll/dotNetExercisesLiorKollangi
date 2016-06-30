using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    class Program
    {
        static void Main(string[] args)
        {       
            Customer[] cArr = new Customer[5];
            cArr[0] = new Customer("liOr",543,"nr 3");
            cArr[1] = new Customer("mAor", 247, "nr 4");
            cArr[2] = new Customer("Bani", 999, "nr 5");
            cArr[3] = new Customer("celiNe", 145, "nr 1");
            cArr[4] = new Customer("cEliNe", 145, "ngr 1");
            Console.WriteLine(cArr[0].CompareTo(null));


            Console.WriteLine(cArr[3].Name+" equals " + cArr[4].Name+" ?: "+ cArr[3].Equals(cArr[4]));
            Console.WriteLine("********************************************");

            Console.WriteLine(cArr[1].Name + " equals " + cArr[2].Name + " ?: " + cArr[1].Equals(cArr[2]));
            Console.WriteLine("********************************************");

            Console.WriteLine(cArr[3].Name + " equals " + cArr+ " ?: " + cArr[3].Equals(cArr));

            Console.WriteLine("********************************************");
            Console.WriteLine("The array after sorting by name:");
            Array.Sort(cArr);
            foreach(Customer c in cArr)
            {
                Console.WriteLine("Name: " + c.Name + " Id: " + c.ID + " Address " + c.Address);
            }
            AnotherCustomerComparer ancc = new AnotherCustomerComparer();
            Console.WriteLine("********************************************");
            Console.WriteLine("The array after sorting by id:");
            Array.Sort(cArr, ancc);
            foreach (Customer c in cArr)
            {
                Console.WriteLine("Name: "+c.Name + " Id: " + c.ID+ " Address "+c.Address);
            }
                  
        }
    }
}
