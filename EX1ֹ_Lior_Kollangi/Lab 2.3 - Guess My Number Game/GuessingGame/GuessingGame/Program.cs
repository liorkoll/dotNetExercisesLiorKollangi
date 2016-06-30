using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = new Random().Next(1, 100);
            int count = 0;
            bool win = false;
            while(!win && count<7)
            {
                Console.WriteLine("Guess a number between 1-100");
                count++;
                int number = int.Parse(Console.ReadLine());
                if (number > secret)
                {
                    Console.WriteLine("too big");
                }
                else if (number > secret)
                {
                    Console.WriteLine("too small");
                }
                else
                    win = true;
            }
            if (count < 7)
            {
                Console.WriteLine("you win! ,number of guesses " + count);
            }
            else
            {
                Console.WriteLine("you failed the correct number is: "+secret);          
            }
        }
    }
}
