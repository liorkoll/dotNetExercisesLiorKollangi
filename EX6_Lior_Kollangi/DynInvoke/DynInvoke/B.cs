﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynInvoke
{
    public class B
    {
        public string Hello(string str)
        {
            return string.Format("Bonjour {0}", str);

        }
    }
}
