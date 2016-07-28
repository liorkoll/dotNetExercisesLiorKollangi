using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
    public class BlackPlayer:Player
    {
        private string Name { get; set; }
        private CheckerColor Color { get; set; }

        public BlackPlayer(string name, CheckerColor color)
        {
            this.Name = name;
            this.Color = color;
        }
        public bool IsMyTurn { get; set; }


        public void moveTo(Dice dice, int cubeNumber, Board board,Bar gameBar, int fromChoice, int toChoice)
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

            if (gameBar.NumOfBlacks > 0)
            {
                if (IsCanGetOutFromBar(board, dice))
                {
                    if (board.Cells[25-diceNumber].CheckersColor == CheckerColor.Black || board.Cells[25-diceNumber].NumOfCheckers <= 1)
                    {
                        board.AddCheckerToBoard(25-diceNumber, CheckerColor.Black);
                        gameBar.RemoveBlackFromBar();
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
                 if ((board.Cells[fromChoice].CheckersColor == CheckerColor.Black) &&
                (board.Cells[toChoice].CheckersColor == CheckerColor.Black || (board.Cells[toChoice].NumOfCheckers <= 1))
                && isMovesAppropriateToCubeWhenCanGetOut(diceNumber, fromChoice, toChoice))
                    {
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
                else {

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
        }
    
        public bool isMovesAppropriateToCube(int diceNum, int fromChoice, int toChoice)
        {
            return diceNum ==   fromChoice- toChoice;
        }
        public bool isMovesAppropriateToCubeWhenCanGetOut(int diceNum, int fromChoice, int toChoice)
        {
            return diceNum >= fromChoice - toChoice;
        }
        public List<int> GetOptionalsMoves(Board board,int diceNum)
        {
            List<int> options = new List<int>();
            for (int i = 1; i < board.Cells.Count-1;i++)
            {
                if ((board.Cells[i].CheckersColor == CheckerColor.Black || board.Cells[i].NumOfCheckers <= 1)
               &&
                    (i + diceNum == 0 && board.Cells[i + diceNum].CheckersColor == CheckerColor.Black))
                {
                    options.Add(i);
                }
            }
                return options;
            }

            public bool IsCanGetOutFromBar(Board board,Dice dice)
        {
              return (board.Cells[25-dice.FirstCube].CheckersColor == CheckerColor.Black || board.Cells[25-dice.FirstCube].NumOfCheckers <= 1)
                  || (board.Cells[25-dice.SecondCube].CheckersColor == CheckerColor.Black || board.Cells[25-dice.SecondCube].NumOfCheckers <= 1);


        }
        public bool IsCanGetOutFromBoard(Board board)
        {
            for(int i = 24; i >6; i--)
            {
                if (board.Cells[i].CheckersColor == CheckerColor.Black)
                {
                    return false;
                }
            }
            return true;

        }

        public bool CheckIfCanGetOutThisCell(Board board,int diceNumber,int from,int to)

        {
            int num = from - to;
            if (num == diceNumber) return true;
           for(int i=18;i< from; i++)
            {
                if (board.Cells[i].CheckersColor == CheckerColor.Black && board.Cells[i].NumOfCheckers>0)

                {
                    return false;
                }
            }
            return true;
        }
    }

    }