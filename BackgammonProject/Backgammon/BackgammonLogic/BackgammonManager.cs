using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
    public class BackgammonManager
    {
        public RedPlayer PlayerRed { get; set; }
        public BlackPlayer PlayerBlack { get; set; }
        public Board GameBoard { get; set; }
        public Dice GameDice { get; set; }
        public Bar GameBar { get; set; }
        
        public bool CheckIfGameOver()
        {
            return PlayerBlack.IsWin(GameBoard, GameBar) || PlayerRed.IsWin(GameBoard, GameBar) ? true : false;
        }

        public BackgammonManager()
        {
            PlayerRed = new RedPlayer("Red Player", CheckerColor.Red);
            PlayerBlack = new BlackPlayer("Black Player", CheckerColor.Black);
            GameBoard = new Board();
            GameDice = new Dice();
            GameBar = new Bar();
            PlayerRed.IsMyTurn = true;
        }
      
    }
}
