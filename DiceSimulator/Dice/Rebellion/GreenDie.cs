using System;
using System.Collections.Generic;

namespace DiceSimulator.Dice.Rebellion
{
    public sealed class GreenDie : BaseDie
    {
        public GreenDie(Random rng) : base(rng, new List<DieResult>
        {
            DieResults.Critical,
            DieResults.Critical,
            DieResults.Blank,
            DieResults.Blank,
            DieResults.Blank,
            DieResults.Blank
        })
        { }
    }
}
