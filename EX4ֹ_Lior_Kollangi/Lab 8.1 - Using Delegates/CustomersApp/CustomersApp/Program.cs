using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    class Program
    {
        public static ICollection<Customer> GetCustomers(ICollection<Customer> customers, CustomerFilter customerFilter)
        {
            List<Customer> filterListCustomers = new List<Customer>();
            if (customerFilter != null)
            {
                foreach (Customer customer in customers)
                {
                    if (customerFilter(customer))
                    {
                        filterListCustomers.Add(customer);
                    }
                }
            }
            return filterListCustomers;
        }
        public static bool startWithAK(Customer customer)
        {
            return (customer.Name.ElementAt(0) >= 'A' && customer.Name.ElementAt(0) <= 'K');

        }
        static void Main(string[] args)
        {

            ICollection<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(new Customer("AVI", 123, "KK 1"));
            listCustomers.Add(new Customer("MAOR", 99, "KK 1"));
            listCustomers.Add(new Customer("DAVID", 125, "KK 1"));

            ICollection<Customer> listCustomers1 = new List<Customer>();
            ICollection<Customer> listCustomers2 = new List<Customer>();
            ICollection<Customer> listCustomers3 = new List<Customer>();


            listCustomers1 = GetCustomers(listCustomers, new CustomerFilter(startWithAK));

            foreach (Customer c in listCustomers1)
            {
                Console.WriteLine(c.Name);
            }
            listCustomers2 = GetCustomers(listCustomers, delegate(Customer customer)
            {
                return (customer.Name.ElementAt(0) >= 'L' && customer.Name.ElementAt(0) <= 'Z');
            });
            foreach (Customer c in listCustomers2)
            {
                Console.WriteLine(c.Name);
            }
            //    listCustomers3 = GetCustomers(listCustomers, customer =>
            //    {             
            //        return (customer.ID<100);
            //});

            var list = GetCustomers(listCustomers, c => c.ID < 100);
            foreach (Customer c in listCustomers3)
            {
                Console.WriteLine(c.ID);
            }
        }
    }

}
