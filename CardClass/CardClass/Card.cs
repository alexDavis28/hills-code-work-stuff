using System;
using System.Collections.Generic;
using System.Text;

namespace CardClass
{
    class Card
    {
        private int rank; // 1-13
        private int suit; // 0-4

        public Card(int r, int s)
        {
            rank = r;
            suit = s;
        }

        public int getRank()
        {
            return rank;
        }

        public int getSuit()
        {
            return suit;
        }

        public int getScore()
        {
            return (getRank() * 4) + getSuit();
        }
    }
}
