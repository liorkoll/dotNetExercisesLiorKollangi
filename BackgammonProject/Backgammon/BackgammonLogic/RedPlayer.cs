using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
    public class RedPlayer:Player
    {
        public RedPlayer(string name,CheckerColor color) : base(name, color)
        {
            
        }

        public override List<int> GetOptionsToMove(Dice d)
        {
            return null;
        }
    }
}
