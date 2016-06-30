using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    class Customer : IComparable<Customer>, IEquatable<Customer>
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Address { get; set; }
        public Customer(string Name, int ID,string Address){
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
            }


        public int CompareTo(Customer other)
        {
         
            if(other is Customer==false)
            {
                throw new InvalidCastException("can't compare with this instance");
            }
            return string.Compare(Name, other.Name, true);
        }

        public bool Equals(Customer other)
        {
          
            if (other is Customer == false)
            {
                throw new InvalidCastException("can't compare with this instance");
            }
            return this.CompareTo(other) == 0 && this.ID == other.ID;
            
        }
    }
}
