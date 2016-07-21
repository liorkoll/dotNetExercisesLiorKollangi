using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
    public interface  Player
    {
         void moveTo(Dice dice, int cubeNumber, Board board, int fromChoice, int toChoice);
         bool isMovesAppropriateToCube(int diceNum, int fromChoice, int toChoice);
         bool isMovesAppropriateToCubeWhenCanGetOut(int diceNum, int fromChoice, int toChoice);
         List<int> GetOptionalsMoves(Board board, int diceNum);
        List<int> GetOptionalsMovesWhenCanGetOut(Board board, int diceNum);


        bool IsCanGetOutFromBar(Board board, Dice dice);
         bool IsCanGetOutFromBoard(Board board);

    }
}
