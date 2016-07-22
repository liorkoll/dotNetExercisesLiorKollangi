using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Student
    {
        public string Id { get; set; }

        public int Grade { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("ID: {0} address: {1}, Age: {2}", Id, Address, Age);
        }
    }
}
