using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonLogic
{
    public class Dice
    {
        public int FirstCube { get; private set; }

        public int SecondCube { get; private set; }

        public int ThirdCube { get; private set; }

        public int ForthCube { get; private set; }

        public bool FirstCubeState { get;  set; }

        public bool SecondCubeState { get;  set; }

        public bool ThirdCubeState { get;  set; }

        public bool ForthCubeState { get;  set; }

        public bool DiceDouble{get;set;}
        

        private static Random rand = new Random();
 
    public void RollDice()
    {
            ResetCubes();
            FirstCube = rand.Next(1, 7);
            SecondCube = rand.Next(1, 7);
            if (FirstCube == SecondCube)
            {
                DiceDouble = true;
                ThirdCube = FirstCube;
                ForthCube = FirstCube;
            }
        }
        public void ResetCubes()
        {
            FirstCube = SecondCube = ThirdCube = ForthCube = 0;
            FirstCubeState = SecondCubeState = ThirdCubeState = ForthCubeState = false;

        }
        public bool isFinished()
        {
            return FirstCubeState == SecondCubeState == ThirdCubeState == ForthCubeState == true;
        }
        public void FinishedAll()
        {
            FirstCubeState = SecondCubeState = ThirdCubeState = ForthCubeState = true;
        }
      
       

    }
}
