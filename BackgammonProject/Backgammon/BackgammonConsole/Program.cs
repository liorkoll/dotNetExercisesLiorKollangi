using BackgammonLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BackgammonManager bm = new BackgammonManager();
            BackgammonConsole bc = new BackgammonConsole();
            bc.DrawGame(bm.GameBoard);
           

            while (!bm.IsGameOver)
            {
                bm.GameDice.RollDice();
                bc.DrawDices(bm.GameDice);


                while (!bm.GameDice.isFinished())
                {
                   
                    Console.WriteLine("*************************************");
                    if (bm.PlayerRed.IsMyTurn == true) {
                        //bm.play
                        //if (bm.PlayerRed.IsCanPlay(bm.GameBoard, bm.GameDice))
                        //{
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
                        //}
                    }
                
                    else
                    {
                        Console.WriteLine("BlackPlayer please choose options to move");
                        Console.WriteLine("cube number?");
                        int cube = int.Parse(Console.ReadLine());
                        Console.Write("move from?");
                        int from = int.Parse(Console.ReadLine());
                        Console.Write("move to?");
                        int to = int.Parse(Console.ReadLine());
                        bm.PlayerBlack.moveTo(bm.GameDice, cube, bm.GameBoard,bm.GameBar, from, to);
                        bc.DrawGame(bm.GameBoard);
                        if (bm.GameDice.isFinished())
                        {
                            bm.PlayerBlack.IsMyTurn = false;
                            bm.PlayerRed.IsMyTurn = true;
                        }

                    }
                    
                }



            }
        }
    }
} 
        
       
        


    

