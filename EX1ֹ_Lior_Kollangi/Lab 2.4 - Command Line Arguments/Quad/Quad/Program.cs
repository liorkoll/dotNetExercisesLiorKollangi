using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quad
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            if (args.Length != 3)
            {
                Console.WriteLine("Error - Expacted 3 confficents,please run again with 3 cofficents");
                return;
            }            
                if (double.TryParse(args[0], out a) == false ||
                    double.TryParse(args[1], out b) == false ||
                    double.TryParse(args[2], out c) == false)
                {
                    Console.WriteLine("Error - Expacted numbers, can't parse, please run again with 3 cofficent");
                return;
                }                                
                    double sqrt = b * b - 4 * a * c;
                    if (sqrt > 0)
                    {
                        double x1 = (-b + System.Math.Sqrt(sqrt)) / (2 * a);
                        double x2 = (-b - System.Math.Sqrt(sqrt)) / (2 * a);
                        Console.WriteLine("Two Real Solutions: " + x1 + "," + x2);
                    }
                    else if (sqrt < 0)
                    {
                        Console.WriteLine("No Solutions");
                    }
                    else
                    {
                        double x = (-b + System.Math.Sqrt(sqrt)) / (2 * a);
                        Console.WriteLine("One Solution:" + x);
                    }
                }
            }

        }
    



