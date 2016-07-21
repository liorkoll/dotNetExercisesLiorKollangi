using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
    public abstract class Player
    {
        public bool Turn { get; set; }
        public CheckerColor PlayerColor { get; private set; }
        public string Name { get; private set; }
        public Player(string name, CheckerColor color)
        {
            Name = name;
            PlayerColor = color;
        }
        public abstract List<int> GetOptionsToMove(Board board, Dice dice);

    }
}
