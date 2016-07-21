using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
    public class Board
    {
        public List<CellOnBoard> Cells { get; private set; }
        public Bar GameBar { get; set; }
        public Board()
        {
            Cells = new List<CellOnBoard>(new CellOnBoard[24]);
            GameBar = new Bar();
            initBoard();
        }
        public void AddCheckerToBoard(int cellNumber, CheckerColor color)
        {
            //   if(color != Cells[cellNumber].CheckersColor)
            //   {
            //     Cells[cellNumber].NumOfCheckers++;
            //   }

            if (Cells[cellNumber].NumOfCheckers == 0)
            {
                Cells[cellNumber] = new CellOnBoard(1, color);
            }
            if (Cells[cellNumber].CheckersColor != color && Cells[cellNumber].NumOfCheckers == 1)
            {
                Cells[cellNumber] = new CellOnBoard(1, color);
                if(color==CheckerColor.Black)
                {
                    GameBar.RemoveRedFromBar();
                }
                else
                {
                    GameBar.RemoveBlackFromBar();
                }
            }
            else
            {
                Cells[cellNumber].NumOfCheckers++;
            }


        }
        public void RemoveCheckerFromBoard(int cellNumber, CheckerColor color)
        {
            //   if (color != Cells[cellNumber].CheckersColor)
            //   {
            //        Cells[cellNumber].NumOfCheckers--;
            //  }
            if (Cells[cellNumber].NumOfCheckers >= 0)
            {
                Cells[cellNumber].NumOfCheckers--;
            }




        }

        private void initBoard()
        {
            for(int i=0;i<24; i++)
            {
                Cells[i] = new CellOnBoard();
            }
            Cells[0] = new CellOnBoard(2, CheckerColor.Red);
            Cells[5] = new CellOnBoard(5, CheckerColor.Black);
            Cells[7] = new CellOnBoard(3, CheckerColor.Black);
            Cells[11] = new CellOnBoard(5, CheckerColor.Red);
            Cells[12] = new CellOnBoard(5, CheckerColor.Black);
            Cells[16] = new CellOnBoard(3, CheckerColor.Red);
            Cells[18] = new CellOnBoard(5, CheckerColor.Red);
            Cells[23] = new CellOnBoard(2, CheckerColor.Black);
        }
    }
}
