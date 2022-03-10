using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace Baccarat
{
    public class BaccaratHand : ScoringHand
    {
        private int score;
        public override int GetScore()
        {
            score = 0;
            foreach (Card card in cards)
            {
                if (card.GetRank()>9)
                {
                    score += 0;
                }
                else
                {
                    score += card.GetRank();
                }
            }

            return score % 10; // Gets rightmost digit
        }
    }
}
