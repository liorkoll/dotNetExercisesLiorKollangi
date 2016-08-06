using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimesCalcilator
{
    class PrimesCalc
    {
        public ManualResetEvent waitHandle {get;set;}

        public PrimesCalc()
        {
            waitHandle = new ManualResetEvent(true);
        }
        public List<int> CalcPrimes(int x, int y, CancellationToken cancellationToken)
        {
            int count = 0;
            List<int> list = new List<int>();

            for (int i = x; i < y; i++)
            {
                //Thread.Sleep(100);
                for (int j = 1; j < y; j++)
                {                                     
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    list.Add(i);
                }
                if (!waitHandle.WaitOne(0))
                {                   
                    break;
                }
                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }
                count = 0;
            }
           
            return list;
        }
    }
}
