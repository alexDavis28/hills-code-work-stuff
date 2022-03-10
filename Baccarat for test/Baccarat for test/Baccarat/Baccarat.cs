using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace Baccarat
{
    public class Baccarat
    {
        private Pack pack;
        private BaccaratHand _PHand;
        private BaccaratHand _BHand;

        private int GetPScore()
        {
            return PHand.GetScore();
        }

        public int PScore
        {
            get
            {
                return GetPScore();
            }
        }
        private int GetBScore()
        {
            return BHand.GetScore();
        }

        public int BScore
        {
            get
            {
                return GetBScore();
            }
        }

        public BaccaratHand PHand
        {
            get
            { return _PHand; }
        }

        public BaccaratHand BHand
        {
            get
            { return _BHand; }
        }
        public Baccarat()
        {
            pack = new Pack();
            _PHand = new BaccaratHand();
            _BHand = new BaccaratHand();
        }

        
        public void Deal()
        {
            pack.Shuffle();
            PHand.AddCard(pack.DealCard());
            PHand.AddCard(pack.DealCard());
            BHand.AddCard(pack.DealCard());
            BHand.AddCard(pack.DealCard());
        }

        public bool Natural()
        {
            if (PScore > 7 || BScore > 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Draw()
        {
            if (PScore >= 0 && PScore <= 5)
            {
                PHand.AddCard(pack.DealCard());

                Card third_card = PHand[2]; //get third card

                int third_card_value;

                if (third_card.GetRank() > 9)
                {
                    third_card_value = 0;
                }
                else if (third_card.GetRank() == 9)
                {
                    third_card_value = -1;
                }
                else if (third_card.GetRank() == 8)
                {
                    third_card_value = -2;
                }
                else
                {
                    third_card_value = third_card.GetRank();
                }
                double value = third_card_value / 2;
                value += 3;

                if (BScore <= value)
                {
                    BHand.AddCard(pack.DealCard());
                }
            }
            else
            {
                if (BScore >= 0 && BScore <= 5)
                {
                    BHand.AddCard(pack.DealCard());
                }
            }
        }
        
    }
}
