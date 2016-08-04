using BackgammonLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonConsole
{
    class BackgammonConsole
    {


        public void DrawGame(Board board)
        {
            Console.Write("13 14 15 16 17 18 19 20 21 22 23 24 25-out");

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < 13; j++)
                {


                    if ((board.Cells[j + 12].CheckersColor == CheckerColor.Black && (board.Cells[j + 12].NumOfCheckers > 6 - i || board.Cells[j + 12].NumOfCheckers >= 5)))
                    {

                        Console.Write("|");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("o");
                        Console.ResetColor();
                        Console.Write("|");

                    }
                    else if ((board.Cells[j + 12].CheckersColor == CheckerColor.Red && (board.Cells[j + 12].NumOfCheckers > 6 - i || board.Cells[j + 12].NumOfCheckers >= 5)))
                    {

                        Console.Write("|");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("o");
                        Console.ResetColor();
                        Console.Write("|");

                    }
                    else
                    {
                        Console.Write("| |");
                    }

                }
            }
            Console.WriteLine();
            int x = 11;

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine();
                //Console.WriteLine("| |");
                for (int j = 1; j < 13; j++)
                {
                    if (j == 1)
                    {
                        x = 11;
                    }
                    if ((board.Cells[j + x].CheckersColor == CheckerColor.Black && (board.Cells[j + x].NumOfCheckers > 6 - i || board.Cells[j + 12].NumOfCheckers >= 5)))
                    {
                        Console.Write("|");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("o");
                        Console.ResetColor();
                        Console.Write("|");
                    }
                    else if ((board.Cells[j + x].CheckersColor == CheckerColor.Red && (board.Cells[j + x].NumOfCheckers > 6 - i || board.Cells[j + 12].NumOfCheckers >= 5)))
                    {
                        Console.Write("|");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("o");
                        Console.ResetColor();
                        Console.Write("|");

                    }
                    else
                    {
                        Console.Write("| |");
                    }
                    x = x - 2;

                }

            }
            Console.WriteLine();
            Console.WriteLine("12 11 10  9  8  7  6  5  4  3  2  1  0-out");
        }

        public void DrawDices(Dice dice)
        {
            Console.WriteLine("First Cube: " + dice.FirstCube);
            Console.WriteLine("Second Cube: " + dice.SecondCube);
            if (dice.DiceDouble)
            {
                Console.WriteLine("Third Cube: " + dice.ThirdCube);
                Console.WriteLine("Forth Cube: " + dice.ForthCube);
            }
        }




        public void RunGame()
        {
            BackgammonManager bm = new BackgammonManager();
            BackgammonConsole bc = new BackgammonConsole();
            bc.DrawGame(bm.GameBoard);


            if (bm.CheckIfGameOver())
            {
                Console.WriteLine("Game over: ");
                if (bm.PlayerBlack.IsWin(bm.GameBoard, bm.GameBar))
                {
                    Console.WriteLine("Black Wins!!!");
                }
                else {
                    Console.WriteLine("Red Wins!!!");

                }
            }

            while (!bm.CheckIfGameOver())
            {
                bm.GameDice.RollDice();
                bc.DrawDices(bm.GameDice);

                while (!bm.GameDice.isFinished())
                {
                    if (bm.PlayerRed.IsMyTurn == true)
                    {
                        //bm.play
                        if (bm.PlayerRed.IsCanPlay(bm.GameBoard, bm.GameBar,bm.GameDice))
                        {

                            Console.WriteLine("RedPlayer please choose options to move");
                            Console.WriteLine("cube number?");
                            int cube = int.Parse(Console.ReadLine());
                            Console.Write("move from?");
                            int from = int.Parse(Console.ReadLine());
                            Console.Write("move to?");
                            int to = int.Parse(Console.ReadLine());
                            bm.PlayerRed.moveTo(bm.GameDice, cube, bm.GameBoard, bm.GameBar, from, to);
                            bc.DrawGame(bm.GameBoard);
                            if (bm.GameDice.isFinished())
                            {
                                bm.PlayerRed.IsMyTurn = false;
                                bm.PlayerBlack.IsMyTurn = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("RedPlayer you can't move");
                        }
                    }

                    else
                    {
                        if (bm.PlayerBlack.IsCanPlay(bm.GameBoard,bm.GameBar, bm.GameDice))
                        {
                            Console.WriteLine("BlackPlayer please choose options to move");
                            Console.WriteLine("cube number?");
                            int cube = int.Parse(Console.ReadLine());
                            Console.Write("move from?");
                            int from = int.Parse(Console.ReadLine());
                            Console.Write("move to?");
                            int to = int.Parse(Console.ReadLine());
                            bm.PlayerBlack.moveTo(bm.GameDice, cube, bm.GameBoard, bm.GameBar, from, to);
                            bc.DrawGame(bm.GameBoard);
                            if (bm.GameDice.isFinished())
                            {
                                bm.PlayerBlack.IsMyTurn = false;
                                bm.PlayerRed.IsMyTurn = true;
                            }

                        }
                        else
                        {
                            Console.WriteLine("BlackPlayer you can't move");
                        }

                    }



                }
            }

        }

    }
}

