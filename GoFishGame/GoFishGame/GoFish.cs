using System;
using System.Collections.Generic;
using System.Text;

namespace CardClasses
{
    class GoFish
    {

        private GoFishHand[] hands;
        private Pack pack;
        private int NumHands;

        public GoFish(int NumPlayers, int NumComputers)
        {
            NumHands = NumPlayers + NumComputers;

            if (NumHands<2)
            {
                throw new ArgumentException("Number of total players must be greater than 1");
            }

            hands = new GoFishHand[NumHands];

            for (int i = 0; i < NumPlayers; i++)
            {
                hands[i] = new PlayerHand();
            }
            for (int i = 0; i < NumComputers; i++)
            {
                hands[i] = new ComputerHand();
            }
        }

        public void Deal()
        {
            pack.Shuffle();

            int CardsToDeal = 7; ;
            if (NumHands>1 && NumHands<3)
            {
                CardsToDeal = 7;
            }
            else if (NumHands>=3)
            {
                CardsToDeal = 5;
            }

            for (int i = 0; i < NumHands; i++)
            {
                for (int j = 0; j < CardsToDeal; j++)
                {
                    hands[i].AddCard(pack.DealCard());
                }
            }
        }

        public void  Play()
        {

        }
    }
}
