using BackgammonLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonConsole
{
    class BackgammonConsole
    {
      

        public void DrawGame(Board board)
        {
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < 13; j++)
                {

                    if ((board.Cells[j + 12].CheckersColor == CheckerColor.Black && (board.Cells[j + 12].NumOfCheckers > 6 - i || board.Cells[j + 12].NumOfCheckers >= 5)))
                    {
                        Console.Write("|B|");

                    }
                    else if ((board.Cells[j + 12].CheckersColor == CheckerColor.Red && (board.Cells[j + 12].NumOfCheckers > 6 - i || board.Cells[j + 12].NumOfCheckers >= 5)))
                    {
                        Console.Write("|R|");

                    }
                    else
                    {
                        Console.Write("| |");
                    }

                }
            }
            Console.WriteLine();
            int x = 11;

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine();
                //Console.WriteLine("| |");
                for (int j = 1; j < 13; j++)
                {
                    if (j == 1)
                    {
                        x = 11;
                    }
                    if ((board.Cells[j + x].CheckersColor == CheckerColor.Black && (board.Cells[j + x].NumOfCheckers > 6 - i || board.Cells[j + 12].NumOfCheckers >= 5)))
                    {
                        Console.Write("|B|");
                    }
                    else if ((board.Cells[j + x].CheckersColor == CheckerColor.Red && (board.Cells[j + x].NumOfCheckers > 6 - i || board.Cells[j + 12].NumOfCheckers >= 5)))
                    {
                        Console.Write("|R|");

                    }
                    else
                    {
                        Console.Write("| |");
                    }
                    x = x - 2;

                }

            }
            Console.WriteLine();
        }

        public void DrawDices(Dice dice)
        {
            Console.WriteLine("First Cube: " + dice.FirstCube);
            Console.WriteLine("Second Cube: " + dice.SecondCube);
            if (dice.DiceDouble)
            {
                Console.WriteLine("Third Cube: " + dice.ThirdCube);
                Console.WriteLine("Forth Cube: " + dice.ForthCube);
            }
        }

        public void DrawGame2(Board board,Bar bar)
        {
           for(int i = 1; i < board.Cells.Count-1; i++)
            {
                if (i == 7 || i == 13 || i == 19) Console.WriteLine();

                Console.Write("["+i +":"+board.Cells[i].NumOfCheckers + " " + board.Cells[i].CheckersColor+"]");
            }
            Console.WriteLine();
            Console.WriteLine("bar - blacks: " + bar.NumOfBlacks);
            Console.WriteLine("bar - reds: " + bar.NumOfReds);

        }




        }

    }
}
