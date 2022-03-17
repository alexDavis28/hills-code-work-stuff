using System;
using System.Collections.Generic;
using System.Linq;
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

        public int[] GetRanks() // list of unique ranks of cards in hand
        {
            int[] ranks = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                ranks[i] = cards[i].GetRank();
            }
            return ranks;
        }

        public int[] GetUniqueRanks()
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

        public void FormBooks()
        {
            foreach (int rank in GetUniqueRanks())
            {
                Book book = new Book(rank);

                int count = 0;

                foreach (Card card in cards)
                {
                    if (rank == card.GetRank())
                    {
                        count++;
                    }
                }

                if (count==4)
                {
                    int j = 0;
                    while (book.Size<4)
                    {
                        if (cards[j%Size].GetRank()==rank)
                        {
                            book.AddCard(RemoveCard(j % Size));
                        }
                        j++;
                    }
                    books.Add(book);
                }
            }
        }

        public void DisplayBooks()
        {
            foreach (Book book in books)
            {
                book.DisplayCards();
            }
        }

        public abstract int RequestCard();

    }
}
