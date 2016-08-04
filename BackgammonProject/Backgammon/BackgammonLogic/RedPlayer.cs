using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
    public class RedPlayer : Player
    {
       private string Name { get; set; }
        private CheckerColor Color { get; set; }

        public RedPlayer(string name, CheckerColor color)
        {
            this.Name = name;
            this.Color = color;
        }

        public bool IsMyTurn { get; set; }

        public bool IsCanPlay(Board board,Bar gameBar,Dice dice)
        {
            if (gameBar.NumOfReds != 0)
            {
                if (!IsCanGetOutFromBar(board, dice))
                {
                    dice.FinishedAll();
                    return false;

                }
            }
            if (dice.DiceDouble)
            {

                IsMyTurn = GetOptionalsMoves(board,gameBar, dice.FirstCube).Count != 0
                    || GetOptionalsMoves(board,gameBar, dice.SecondCube).Count != 0
                    || GetOptionalsMoves(board,gameBar, dice.ThirdCube).Count != 0
                    || GetOptionalsMoves(board,gameBar, dice.ForthCube).Count != 0;
            }
            //else
            {

                IsMyTurn = GetOptionalsMoves(board,gameBar, dice.FirstCube).Count != 0 || GetOptionalsMoves(board,gameBar, dice.SecondCube).Count != 0; ;
            }
            if (!IsMyTurn)
            {
                dice.FinishedAll();
            }
            return IsMyTurn;
        }
        public int GetDiceNumber(int cubeNumber,Dice dice)
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
            return diceNumber;
        }
        public void SetCubeState(int cubeNumber,Dice dice)
        {
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



        public void moveTo(Dice dice, int cubeNumber, Board board,Bar gameBar, int fromChoice, int toChoice)
        {
            int diceNumber = GetDiceNumber(cubeNumber, dice);
            

            //check if is in the bar
            if (gameBar.NumOfReds > 0)
            {
                if (IsCanGetOutFromBar(board, dice))
                {
                    if (board.Cells[diceNumber].CheckersColor == CheckerColor.Red || board.Cells[diceNumber].NumOfCheckers <= 1)
                    {
                        board.AddCheckerToBoard(diceNumber, CheckerColor.Red);
                        gameBar.RemoveRedFromBar();
                        SetCubeState(cubeNumber, dice);
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

                if (IsCanGetOutFromBoard(board) && toChoice == 25)
                {
                    //if user chose to exit-25 check if can
                    if (isMovesAppropriateToCubeWhenCanGetOut(diceNumber, fromChoice, toChoice) && CheckIfCanGetOutThisCell(board, diceNumber, fromChoice, toChoice)) {
                        board.RemoveCheckerFromBoard(fromChoice, CheckerColor.Red);
                        SetCubeState(cubeNumber, dice);
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
                        SetCubeState(cubeNumber, dice);

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
        public List<int> GetOptionalsMoves(Board board,Bar gameBar, int diceNum)
        {
            
            List<int> options = new List<int>();
            for (int i = 1; i < board.Cells.Count; i++)
            {
                if (i - diceNum > 0) {
                    if ((board.Cells[i].CheckersColor == CheckerColor.Red || board.Cells[i].NumOfCheckers <= 1)
                   &&
                       (board.Cells[i - diceNum].CheckersColor == CheckerColor.Red))
                    {
                        options.Add(i);

                    }
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
        public bool CheckIfCanGetOutThisCell(Board board, int diceNumber, int from, int to)

        {
            int num = from - to;
            if (num == diceNumber) return true;
            for (int i = 19; i < from ; i++)
            {
                if (board.Cells[i].CheckersColor == CheckerColor.Red && board.Cells[i].NumOfCheckers > 0)

                {
                    return false;
                }
            }
            return true;
        }

      

        public bool IsWin(Board board, Bar gameBar)
        {
            if (gameBar.NumOfReds != 0)
            {
                return false;
            }
            for (int i = 1; i < 25; i++)
            {

                if (board.Cells[i].NumOfCheckers > 0 && board.Cells[i].CheckersColor == CheckerColor.Red)
                    return false;
            }
        
            return true;
        }
            
    }
}
