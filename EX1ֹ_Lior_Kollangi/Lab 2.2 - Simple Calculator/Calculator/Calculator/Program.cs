﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter 2 double numbers and operator  (+,-,* or /)");
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());
            switch (oper)
            {
                case '+' :
                    Console.WriteLine(number1 + number2);
                    break;
                case '-':
                    Console.WriteLine(number1 - number2);
                    break;
                case '*':
                    Console.WriteLine(number1 * number2);
                    break;
                case '/':
                    Console.WriteLine(number1 / number2);
                    break;
                default:
                    Console.WriteLine("Invalid operator ");
                    break;
            }
        }
    }
}
