using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLib
{
    public class Game
    {
        private const int numberOfPlayers = 2;
        private const int numberOfPoints = 26;      // (24 + 1 for the bar + 1 for off the board)
        private const int numberOfPointsInHomeBoard = 6;
        private const int maxNumberOfCountersPerPoint = 5;

        public Game(Player player1, Player player2)
        {

            Black = player1;
            White = player2;
            CurrentPlayer = 1;
            StartedOn = DateTime.Now;
            InitializeBoard();
            Dice = new int[2];
        }

        public Player Black { get; set; }

        public Player White { get; set; }

        public int CurrentPlayer { get; set; }

        public DateTime StartedOn { get; set; }

        public int[,] Board { get; set; }

        public int[] Dice { get; set; }
        private void InitializeBoard()
        {
            Board = GetNewBoard();
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Board[i - 1, 1] = 2;
                Board[i - 1, 12] = 5;
                Board[i - 1, 17] = 3;
                Board[i - 1, 19] = 5;
            }
        }
        private int[,] GetNewBoard()
        {
            return new int[numberOfPlayers, numberOfPoints];
        }

        public void RollDice()
        {
            var rnd = new Random();
            Dice[0] = rnd.Next(1, 6);
            Dice[1] = rnd.Next(1, 6);
        }

        public void PrintBoard()
        {

        }



    }
}
