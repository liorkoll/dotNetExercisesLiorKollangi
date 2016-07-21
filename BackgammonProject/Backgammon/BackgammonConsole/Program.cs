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
            //while (!bm.IsGameOver)
            //{
                bm.GameDice.RollDice();
                bc.DrawDices(bm.GameDice);



            //}



        }
    }   
        }
       
        


    

