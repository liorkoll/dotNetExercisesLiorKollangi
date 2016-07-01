using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{

    delegate bool CustomerFilter(Customer customer);

    class Customer : IComparable<Customer>, IEquatable<Customer>
    {
        public string Name { get; private set; }
        public int ID { get;private set; }
        public string Address { get; private set; }
        public Customer(string name, int id,string address){
            this.ID = id;
            this.Name = name;
            this.Address = address;
            }


        public int CompareTo(Customer other)
        {
            if (other == null) throw new ArgumentNullException("can't compare with null object");
            return string.Compare(Name, other.Name, true);
        }

        public bool Equals(Customer other)
        {
            return this.CompareTo(other) == 0 && this.ID == other.ID;
            
        }
       
      





       
        
    }
}
