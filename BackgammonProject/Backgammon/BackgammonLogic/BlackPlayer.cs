using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
    class BlackPlayer:Player
    {
       public void getMoveOptions(Dice dice,Board board)
        {
            //check if his color on the bar
            if(board.GameBar.NumOfBlacks == 0)
            {
                List <int> moves = new List<int>();

            }
        }

    }
}
