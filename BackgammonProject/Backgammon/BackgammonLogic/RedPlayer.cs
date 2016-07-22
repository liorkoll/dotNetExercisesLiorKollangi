using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
    public class RedPlayer : Player
    {
        public void moveTo(Dice dice, int cubeNumber, Board board, int fromChoice, int toChoice)
        {
            int diceNumber = 0;
            if (cubeNumber == 1)
            {
                diceNumber = dice.FirstCube;
            }
            if (cubeNumber == 2)
            {
                diceNumber = dice.SecondCube;
            }
            if (cubeNumber == 3)
            {
                diceNumber = dice.ThirdCube;
            }
            if (cubeNumber == 4)
            {
                diceNumber = dice.ForthCube;
            }

            //check if is in the bar
            if (board.GameBar.NumOfReds > 0)
            {
                if (IsCanGetOutFromBar(board, dice))
                {
                    if (board.Cells[diceNumber].CheckersColor == CheckerColor.Red || board.Cells[diceNumber].NumOfCheckers <= 1)
                    {
                        board.AddCheckerToBoard(diceNumber, CheckerColor.Red);
                        board.GameBar.RemoveRedFromBar();
                        if (cubeNumber == 1)
                        {
                            dice.FirstCubeState = true;
                        }
                        if (cubeNumber == 2)
                        {
                            dice.SecondCubeState = true;
                        }
                        if (cubeNumber == 3)
                        {
                            dice.ThirdCubeState = true;
                        }
                        if (cubeNumber == 4)
                        {
                            dice.ForthCubeState = true;
                        }
                    }
                }

                else {
                    if (!IsCanGetOutFromBar(board, dice))
                    {
                        dice.FinishedAll();
                    }
                }
            }

            else {
                //check if can move with this number 
                if (IsCanGetOutFromBoard(board))
                {
                    if ((board.Cells[fromChoice].CheckersColor == CheckerColor.Red) &&
                   (board.Cells[toChoice].CheckersColor == CheckerColor.Red || (board.Cells[toChoice].NumOfCheckers <= 1))
                   && isMovesAppropriateToCubeWhenCanGetOut(diceNumber, fromChoice, toChoice))
                    {
                        board.RemoveCheckerFromBoard(fromChoice, CheckerColor.Red);
                        if (cubeNumber == 1)
                        {
                            dice.FirstCubeState = true;
                        }
                        if (cubeNumber == 2)
                        {
                            dice.SecondCubeState = true;
                        }
                        if (cubeNumber == 3)
                        {
                            dice.ThirdCubeState = true;
                        }
                        if (cubeNumber == 4)
                        {
                            dice.ForthCubeState = true;
                        }

                    }


                }
                else {

                    if ((board.Cells[fromChoice].CheckersColor == CheckerColor.Red) &&
                 (board.Cells[toChoice].CheckersColor == CheckerColor.Red || (board.Cells[toChoice].NumOfCheckers <= 1))
                 &&
                isMovesAppropriateToCube(diceNumber, fromChoice, toChoice))
                    {

                        board.AddCheckerToBoard(toChoice, CheckerColor.Red);
                        board.RemoveCheckerFromBoard(fromChoice, CheckerColor.Red);
                        if (cubeNumber == 1)
                        {
                            dice.FirstCubeState = true;
                        }
                        if (cubeNumber == 2)
                        {
                            dice.SecondCubeState = true;
                        }
                        if (cubeNumber == 3)
                        {
                            dice.ThirdCubeState = true;
                        }
                        if (cubeNumber == 4)
                        {
                            dice.ForthCubeState = true;
                        }

                    }
                }
            }
        }

        public bool isMovesAppropriateToCube(int diceNum, int fromChoice, int toChoice)
        {
            return diceNum == toChoice - fromChoice;
        }
        public bool isMovesAppropriateToCubeWhenCanGetOut(int diceNum, int fromChoice, int toChoice)
        {
            return diceNum >= toChoice - fromChoice;
        }
        public List<int> GetOptionalsMoves(Board board, int diceNum)
        {
            List<int> options = new List<int>();
            for (int i = 1; i < board.Cells.Count; i++)
            {
                if ((board.Cells[i].CheckersColor == CheckerColor.Red || board.Cells[i].NumOfCheckers <= 1)
               &&
                    (i - diceNum == 0 && board.Cells[i - diceNum].CheckersColor == CheckerColor.Red))
                {
                    options.Add(i);

                }
           
            }



            return options;
        }

        public bool IsCanGetOutFromBar(Board board, Dice dice)
        {
            return (board.Cells[dice.FirstCube].CheckersColor == CheckerColor.Red || board.Cells[dice.FirstCube].NumOfCheckers <= 1)
                  || (board.Cells[dice.SecondCube].CheckersColor == CheckerColor.Red || board.Cells[dice.SecondCube].NumOfCheckers <= 1);



        }
        public bool IsCanGetOutFromBoard(Board board)
        {
            for (int i = 1; i < 19; i++)
            {
                if (board.Cells[i].CheckersColor == CheckerColor.Red)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
