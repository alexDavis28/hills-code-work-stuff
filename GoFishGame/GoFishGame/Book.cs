using System;
using System.Collections.Generic;
using System.Text;

namespace CardClasses
{
    class Book : Hand
    {
        private int rank; // rank of the book
        public int GetRank()
        {
            return rank;
        }

        public string GetRankAsString()
        {
            string[] ranks = { "Ace", "Two", "Three", "Four", "Five",
              "Six","Seven", "Eight", "Nine", "Ten",
              "Jack","Queen", "King" };
            return ranks[rank - 1] + "s";
        }

        public Book(int r)
        {
            rank = r;
        }
    }
}
