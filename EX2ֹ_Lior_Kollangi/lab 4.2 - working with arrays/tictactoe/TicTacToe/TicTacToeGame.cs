using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToeGame
    {
       public enum Cell {E,X,O};
        public Cell[,] board= new Cell[3,3];
        public bool IsGameOver { get; set; }
        public void display()
        {

            for (int i = 0; i < board.GetLength(0); i++)
            {

                for (int j = 0; j < board.GetLength(1); j++)
                {

                    Console.Write("{0,4}", board[i, j]);
                }
                Console.WriteLine();
            }
        }
        public bool moveTo(string s1,string s2,Cell c)
        {
            int i;
            int j;
            if (int.TryParse(s1,out i)==false || int.TryParse(s2, out j) == false){
                return false;
            }           
            if ( i < 0 || i > 2 || j < 0 || j > 2)
                return false;
            if (board[i, j] != Cell.E)
            {
                return false;
            }
            board[i, j] = c;
            if (board[0, 0] == c && board[0, 1] == c && board[0, 2] == c ||
                board[1, 0] == c && board[1, 1] == c && board[1, 2] == c ||
                board[2, 0] == c && board[2, 1] == c && board[2, 2] == c ||
                board[0, 0] == c && board[1, 0] == c && board[2, 0] == c ||
                board[0, 1] == c && board[1, 1] == c && board[2, 1] == c ||
                board[0, 2] == c && board[1, 2] == c && board[2, 2] == c ||
                board[0, 0] == c && board[1, 1] == c && board[2, 2] == c ||
                board[0, 2] == c && board[1, 1] == c && board[2, 0] == c) {
                IsGameOver = true;
                
            }
            return true;
        }
      
            }
    
}
