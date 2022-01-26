using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame
{
    class Dice
    {
        private int value;
        private int sides;
        private Random rnd = new Random();

        public Dice(int numSides)
        {
            sides = numSides;
            Roll();
        }

        public int GetValue()
        {
            return value;
        }

        public void Roll()
        {
            value = rnd.Next(sides) + 1;
        }
    }
}
