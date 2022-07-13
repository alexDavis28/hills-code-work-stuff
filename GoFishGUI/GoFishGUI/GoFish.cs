using System;
using System.Collections.Generic;
using System.Text;

namespace GoFishGUI
{
    class GoFish
    {

        private Pack pack = new Pack();

        private GoFishHand[] hands = new GoFishHand[4] {new PlayerHand(), new ComputerHand(), new ComputerHand(), new ComputerHand() };

        private int cards_to_deal = 5;

        public int current_turn;
        public int next_turn;
        public int cards_in_a_row = 9;

        public GoFishHand[] Hands
        {
            get {
                return hands;
            }
        }


        public void ShuffleCards()
        {
            pack.Shuffle();
        }

        public void DealCards()
        {
            for (int i = 0; i < cards_to_deal; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    hands[j].AddCard(pack.DealCard());
                }
            }
        }

        public Card DealCard(int hand)
        {
            Card c = pack.DealCard();
            hands[hand].AddCard(c);
            return c;
        }

        public void PlayerSortHand()
        {
            hands[0].SortCards();
        }

        public int ComputerRequestCard(int turn)
        {
            return hands[turn].RequestCard();
        }

        public bool HasCardResponse(int hand, int rank)
        {
            return hands[hand].HasCard(rank);
        }

        public int TransferCards(int p1, int p2, int rank)
        {
            int num = 0;
            for (int suit = 0; suit < 4; suit++)
            {
                int index = hands[p2].FindCard(rank, suit);
                if (index != -1)
                {
                    hands[p1].AddCard(hands[p2].RemoveCard(index));
                    num++;
                }
            }
            if (num==0)
            {
                throw new Exception();
            }
            return num;
        }

        public string RankAsString(int rank)
        {
            string[] ranks = { "Ace", "Two", "Three", "Four", "Five",
              "Six","Seven", "Eight", "Nine", "Ten",
              "Jack","Queen", "King" };
            return ranks[rank - 1] + "s";
        }
    }
}
