using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
    public class Bar
    {
        public int NumOfReds { get; private set; }
        public int NumOfBlacks { get; private set; }
        public void AddBlackToBar()
        {
            NumOfBlacks++;
        }
        public void AddRedToBar()
        {
            NumOfReds++;
        }
        public void RemoveBlackFromBar()
        {
            NumOfBlacks--;
        }
        public void RemoveRedFromBar()
        {
            NumOfReds--;
        }

    }
}
