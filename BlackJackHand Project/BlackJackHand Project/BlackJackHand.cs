using System;
using System.Collections.Generic;
using System.Text;

namespace CardClasses
{
    public class BlackJackHand : Hand
    {
        public int GetScore()
        {
            int score = 0;
            int aces_count = 0;

            foreach (Card card in cards)
            {

                int rank = card.GetRank();
                
                if (rank == 1) // ace
                {
                    score += 11;
                    aces_count++;
                }
                else if (rank >= 11) // jack, queen, king
                {
                    score += 10;
                }
                else
                {
                    score += rank;
                }
            }

            if (score >= 21 && aces_count > 0)
            {
                score -= aces_count * 10;
            }

            return score;

        }
    }
}
