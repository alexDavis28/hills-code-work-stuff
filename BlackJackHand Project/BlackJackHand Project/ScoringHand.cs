using System;
using System.Collections.Generic;
using System.Text;

namespace CardClasses
{
    public abstract class ScoringHand : Hand
    {
        public abstract int GetScore();
    }
}
