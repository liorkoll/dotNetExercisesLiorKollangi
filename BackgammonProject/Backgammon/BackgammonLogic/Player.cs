using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
    public interface  Player
    {
        bool IsCanPlay(Board board,Bar gameBar, Dice dice);
         void moveTo(Dice dice, int cubeNumber, Board board, Bar gameBar, int fromChoice, int toChoice);
         bool isMovesAppropriateToCube(int diceNum, int fromChoice, int toChoice);
         bool isMovesAppropriateToCubeWhenCanGetOut(int diceNum, int fromChoice, int toChoice);
         List<int> GetOptionalsMoves(Board board, Bar gameBar,int diceNum);


        bool IsWin(Board board ,Bar gameBar);
        
        


        bool IsCanGetOutFromBar(Board board, Dice dice);
         bool IsCanGetOutFromBoard(Board board);

    }
}
