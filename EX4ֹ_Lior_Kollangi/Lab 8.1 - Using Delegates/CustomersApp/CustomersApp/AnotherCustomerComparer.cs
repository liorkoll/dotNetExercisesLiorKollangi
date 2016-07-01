using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    class AnotherCustomerComparer : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            if (x == null || y == null) throw new ArgumentNullException("can't compare with null object");
            return x.ID.CompareTo(y.ID);
        }
    }
}
