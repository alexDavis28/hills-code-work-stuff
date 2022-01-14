using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame
{
    class Dice
    {
        public int value;
        public int sides;
        Random rnd = new Random();

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
