using System;
using System.Collections.Generic;
using System.Text;

namespace CardClasses
{
    class ComputerHand : GoFishHand
    {
        public ComputerHand()
        {
            HandType = "Computer";
        }
        public override bool HasCard(int rank)
        {
            throw new NotImplementedException();
        }
    }
}
