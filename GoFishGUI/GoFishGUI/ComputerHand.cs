using System;
using System.Collections.Generic;
using System.Text;

namespace GoFishGUI
{
    class ComputerHand : GoFishHand
    {
        private Random random = new Random();

        public ComputerHand()
        {
            HandType = "Computer";
        }
        public override int RequestCard()
        {
            // request a card of a random rank that exists in the computer's hand
            int requested_rank = -1;
            while (requested_rank == -1)
            {
                requested_rank = random.Next(1, 14);
                if (!HasCard(requested_rank))
                {
                    requested_rank = -1;
                }
            }
            return requested_rank;
        }
    }
}
