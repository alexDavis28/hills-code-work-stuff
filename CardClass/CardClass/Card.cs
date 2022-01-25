using System;
using System.Collections.Generic;
using System.Text;

namespace CardClass
{
    class Card
    {
        private int rank; // 1-13
        private int suit; // 0-3

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

        public string suitAsString()
        {
            string suit_string = ""; ;
            switch (suit)
            {
                case 0:
                    suit_string = "Clubs";
                    break;
                case 1:
                    suit_string = "Diamonds";
                    break;
                case 2:
                    suit_string = "Hearts";
                    break;
                case 3:
                    suit_string = "Spades";
                    break;
                default:
                    break;
            }
            return suit_string;
        }

        public string rankAsString()
        {
            string rank_string = "";
            switch (rank)
            {
                case 1:
                    rank_string = "Ace";
                    break;
                case 11:
                    rank_string = "Jack";
                    break;
                case 12:
                    rank_string = "Queen";
                    break;
                case 13:
                    rank_string = "King";
                    break;
                default:
                    rank_string = Convert.ToString(rank);
                    break;
            }
            return rank_string;
        }
    }
}
