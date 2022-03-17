using System;
using System.Collections.Generic;
using System.Text;

namespace CardClasses
{
    abstract class GoFishHand : Hand
    {
        protected string HandType;
        protected List<Book> books = new List<Book>();

        public string GetHandType()
        {
            return HandType;
        }

        public int BookCount
        {
            get { return books.Count; } 
        }

        public int[] GetRanks()
        {
            int[] ranks = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                ranks[i] = cards[i].GetRank();
            }
            return ranks;
        }
        public bool HasCard(int rank) // check if a card of the specified rank exists in the hand
        {
            bool card_present = false;
            int[] ranks = GetRanks();
            for (int i = 0; i < Size; i++)
            {
                if (ranks[i]==rank)
                {
                    card_present = true;
                }
            }
            return card_present;
        }
        public abstract int RequestCard();

        public abstract void FormBooks();
    }
}
