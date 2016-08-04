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
            Cells = new List<CellOnBoard>(new CellOnBoard[26]);
            GameBar = new Bar();
            initBoard();
        }
        public void AddCheckerToBoard(int cellNumber, CheckerColor color)
        {

            if (Cells[cellNumber].NumOfCheckers == 0)
            {
                Cells[cellNumber] = new CellOnBoard(1, color);
            }
            else if (Cells[cellNumber].CheckersColor != color && Cells[cellNumber].NumOfCheckers == 1)
            {
                Cells[cellNumber] = new CellOnBoard(1, color);
                if (color == CheckerColor.Black)
                {
                    GameBar.AddRedToBar();
                }
                else
                {
                    GameBar.AddBlackToBar();
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
            for(int i=0;i<26; i++)
            {
                Cells[i] = new CellOnBoard();
            }


            //O and 25 is out of game
            Cells[1] = new CellOnBoard(2, CheckerColor.Red);
            Cells[6] = new CellOnBoard(5, CheckerColor.Black);
            Cells[8] = new CellOnBoard(3, CheckerColor.Black);
            Cells[12] = new CellOnBoard(5, CheckerColor.Red);
            Cells[13] = new CellOnBoard(5, CheckerColor.Black);
            Cells[17] = new CellOnBoard(3, CheckerColor.Red);
            Cells[19] = new CellOnBoard(5, CheckerColor.Red);
            Cells[24] = new CellOnBoard(2, CheckerColor.Black);
            //for(int i = 1; i < 25; i++)
            //{
            //    Cells[i]= new CellOnBoard(5, CheckerColor.Black);
            //}


        }
    }
}
