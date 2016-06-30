using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame g = new TicTacToeGame();

            string s1, s2;
            int count = 0;
            bool illegalStep = false;
            g.display();

            while (g.IsGameOver == false)
            {
                while (illegalStep == false)
                {
                    Console.WriteLine("X  is your turn");
                    Console.WriteLine("please choose cell i (0-2)");
                    s1=(Console.ReadLine());
                    Console.WriteLine("please choose cell J (0-2)");
                    s2 = (Console.ReadLine());
                    illegalStep = g.moveTo(s1, s2, TicTacToeGame.Cell.X);
                }
                count++;
                illegalStep = false;
                g.display();
                if (g.IsGameOver == true)
                {
                    Console.WriteLine("X WIN!!!");
                    break;
                }
                if (count == 9)
                {
                    Console.WriteLine("TIKO!!!");
                    break;
                }


                while (illegalStep == false)
                {
                    Console.WriteLine("O  is your turn please choose cell i and j");
                    Console.WriteLine("please choose cell i (0-2)");
                    s1 = (Console.ReadLine());
                    Console.WriteLine("please choose cell J (0-2)");
                    s2 = (Console.ReadLine());
                    illegalStep = g.moveTo(s1, s2, TicTacToeGame.Cell.O);
                }
                count++;
                illegalStep = false;
                g.display();
                if (g.IsGameOver == true)
                {
                    Console.WriteLine("O WIN!!!");
                    break;
                }
                if (count == 9)
                {
                    Console.WriteLine("TIKO!!!");
                    break;
                }
            }

        }
    }
}
