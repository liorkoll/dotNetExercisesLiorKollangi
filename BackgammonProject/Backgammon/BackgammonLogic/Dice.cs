using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
    class Dice
    {
        public int FirstCube { get; private set; }

        public int SecondCube { get; private set; }

        public int ThirdCube { get; private set; }

        public int ForthCube { get; private set; }

        private static Random rand = new Random();
 
    public void RollDice()
    {
            FirstCube = rand.Next(1, 7);
            SecondCube = rand.Next(1, 7);
            if (FirstCube == SecondCube)
            {
                ThirdCube = FirstCube;
                ForthCube = FirstCube;
            }
        }
        public void ResetCubes()
        {
            FirstCube = SecondCube = ThirdCube = ForthCube = 0;
            
        }
    }
}
