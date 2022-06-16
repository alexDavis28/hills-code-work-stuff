using System;
using System.Collections.Generic;
using System.Text;

namespace GoFishGUI
{
    class Book : Hand
    {
        // Book class for the sets of 4 cards of the same rank that are needed to win
        // Functions pretty much as a hand that will only have 4 cards

        private int rank; // rank of the cards in the book
        public int GetRank()
        {
            return rank;
        }

        public string GetRankAsString()
        {
            string[] ranks = { "Ace", "Two", "Three", "Four", "Five",
              "Six","Seven", "Eight", "Nine", "Ten",
              "Jack","Queen", "King" };
            return ranks[rank - 1];
        }

        public Book(int r)
        {
            rank = r;
        }
    }
}
