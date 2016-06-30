using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            string binaryNum = "";      
            int num = int.Parse(Console.ReadLine());
            int Number = num;
            int r;
            while (num > 0)
            {
                r = num % 2;
                num /= 2;
                binaryNum = r.ToString() + binaryNum;
            }
            Console.WriteLine("binary display: " + binaryNum);
            int count = 0;

            while (Number > 0)
            {
                count += Number & 1;
                Number >>= 1;
            }
        Console.WriteLine("numbers of 1: "+count);

        }
    }
}
