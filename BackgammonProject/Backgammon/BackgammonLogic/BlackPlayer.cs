using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
   public class BlackPlayer:Player
    {
        public BlackPlayer(string name, CheckerColor color) : base(name, color)
        {
            
        }

        public override List<int> GetOptionsToMove(Board board, Dice dice)
        {
            for(int i = 0; i < board.Cells.Count; i++)
            {
              
            }
        }
    }
}
