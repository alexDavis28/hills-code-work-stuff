using System;
using System.Collections.Generic;
using System.Text;

namespace CardClasses
{
    abstract class GoFishHand : Hand
    {
        protected string HandType;
        protected Book[] books;

        public string GetHandType()
        {
            return HandType;
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
        public bool HasCard(int rank)
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
    }
}
