using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLib
{
    public class InsufficientFundsException:Exception
    {
        public InsufficientFundsException(string m) : base( m) { }

        public InsufficientFundsException() : base()
        {
            
        }
        public InsufficientFundsException(string m, Exception inner)
            : base(m, inner)
        {

        }
    }
}
