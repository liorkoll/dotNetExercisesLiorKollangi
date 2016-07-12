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
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 12; j++)
                {

                    if ((board.Cells[j + 12].CheckersColor == CheckerColor.Black && (board.Cells[j + 12].NumOfCheckers > 5 - i || board.Cells[j + 12].NumOfCheckers >= 5)))
                    {
                        Console.Write("|B|");

                    }
                    else if ((board.Cells[j + 12].CheckersColor == CheckerColor.Red && (board.Cells[j + 12].NumOfCheckers > 5 - i || board.Cells[j + 12].NumOfCheckers >= 5)))
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

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine();
                //Console.WriteLine("| |");
                for (int j = 0; j < 12; j++)
                {
                    if (j == 0)
                    {
                        x = 11;
                    }
                    if ((board.Cells[j + x].CheckersColor == CheckerColor.Black && (board.Cells[j + x].NumOfCheckers > 5 - i || board.Cells[j + 12].NumOfCheckers >= 5)))
                    {
                        Console.Write("|B|");
                    }
                    else if ((board.Cells[j + x].CheckersColor == CheckerColor.Red && (board.Cells[j + x].NumOfCheckers > 5 - i || board.Cells[j + 12].NumOfCheckers >= 5)))
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
        }
        }
}
