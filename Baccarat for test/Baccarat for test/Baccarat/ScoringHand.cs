﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    public abstract class ScoringHand : Hand
    {
        public abstract int GetScore(); 
    }
}
