using System;
using System.Collections.Generic;
using System.Text;

namespace GoFishGUI
{
    class PlayerHand : GoFishHand
    {
        public PlayerHand()
        {
            HandType = "Player";
        }

        public override int RequestCard()
        {
            throw new NotImplementedException();
        }
    }
}
