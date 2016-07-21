using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
    public class BlackPlayer
    {


        public void moveTo(Dice dice, int cubeNumber, Board board, int fromChoice, int toChoice)
        {
            int diceNumber = 1;
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
            if (board.GameBar.NumOfBlacks > 0)
            {
                if (IsCanGetOutFromBar(board, dice))
                {
                    if (board.Cells[diceNumber].CheckersColor == CheckerColor.Black || board.Cells[diceNumber].NumOfCheckers <= 1)
                    {
                        board.AddCheckerToBoard(diceNumber, CheckerColor.Black);
                        board.GameBar.RemoveBlackFromBar();
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

                if ((board.Cells[fromChoice].CheckersColor == CheckerColor.Black) &&
             (board.Cells[toChoice].CheckersColor == CheckerColor.Black || (board.Cells[toChoice].NumOfCheckers <= 1))
             &&
            isMovesAppropriateToCube(diceNumber, fromChoice, toChoice))
                {

                    board.AddCheckerToBoard(toChoice, CheckerColor.Black);
                    board.RemoveCheckerFromBoard(fromChoice, CheckerColor.Black);
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
    





















    
        public bool isMovesAppropriateToCube(int diceNum, int fromChoice, int toChoice)
        {
            return diceNum == toChoice - fromChoice;
        }
        public List<int> GetOptionalsMoves(Board board,int diceNum)
        {
            List<int> options = new List<int>();
            for (int i = 0; i < board.Cells.Count; i++)
            {
                if ((board.Cells[i].CheckersColor == CheckerColor.Black || board.Cells[i].NumOfCheckers <= 1)
               &&
                    (i - diceNum == 0 && board.Cells[i - diceNum].CheckersColor == CheckerColor.Black))
                {
                    options.Add(i);
                }
            }
                return options;
            }

            public bool IsCanGetOutFromBar(Board board,Dice dice)
        {
         return   (board.Cells[dice.FirstCube].CheckersColor == CheckerColor.Black || board.Cells[dice.FirstCube].NumOfCheckers <= 1)
               || (board.Cells[dice.SecondCube].CheckersColor == CheckerColor.Black || board.Cells[dice.SecondCube].NumOfCheckers <= 1);

            

        }
        }

    }