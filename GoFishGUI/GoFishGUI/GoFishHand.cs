using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoFishGUI
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

        public int[] GetRanks() // list of ranks of cards in hand
        {
            int[] ranks = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                ranks[i] = cards[i].GetRank();
            }
            return ranks;
        }

        public int[] GetUniqueRanks() // list of unique ranks in hand
        {
            int[] ranks = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                ranks[i] = cards[i].GetRank();
            }
            return ranks.Distinct().ToArray();
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

        public void FormBooks() // Check through all ranks that exist in the hand, then if the full book of 4 cards exists in the hand remove those cards and store them in a book
        {
            foreach (int rank in GetUniqueRanks())
            {
                Book book = new Book(rank);

                int count = 0;

                foreach (Card card in cards) // Count how many cards of rank "rank" are in the hand
                {
                    if (rank == card.GetRank())
                    {
                        count++;
                    }
                }

                if (count==4) // If there is a full book:
                {
                    int j = 0;
                    while (book.Size<4)
                    {
                        if (cards[j%Size].GetRank()==rank)
                        {
                            book.AddCard(RemoveCard(j % Size)); // Add each card of the rank to a book and remove those cards from the hand
                        }
                        j++;
                    }
                    books.Add(book); // store the mew book
                }
            }
        }

        public abstract int RequestCard();

    }
}
