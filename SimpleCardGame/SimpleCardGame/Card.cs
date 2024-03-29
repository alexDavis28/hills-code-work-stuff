﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    public class Card
    {
        private int rank;
        private int suit;

        public Card(int r, int s)
        {
            rank = r;
            suit = s;
        }
        public int GetRank()
        {
            return rank;
        }
        public int GetSuit()
        {
            return suit;
        }
        public string GetSuitAsString()
        {
            switch (suit)
            {
                case 0:
                    return "Clubs";
                case 1:
                    return "Diamonds";
                case 2:
                    return "Hearts";
                case 3:
                    return "Spades";
                default:
                    return "Invalid Suit";
            }
        }
        public string GetRankAsString()
        {
            switch (rank)
            {

                case 1:
                    return "Ace";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
                case 10:
                    return "Ten";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    return "Invalid Rank";

            }
        }
        public string GetName()
        {
         return GetRankAsString() + " of " + GetSuitAsString();
        }

        public int GetScore()
        {
            return (rank - 1) * 4 + 1 + suit;
        }

    }
}

