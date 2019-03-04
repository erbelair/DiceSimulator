using System;
using System.Collections.Generic;

namespace DiceSimulator.Dice.Rebellion
{
    public sealed class Die : BaseDie
    {
        public Die(Random rng) : base(rng, new List<DieResult>
        {
            DieResults.Lightsaber,
            DieResults.Critical,
            DieResults.Hit,
            DieResults.Hit,
            DieResults.Blank,
            DieResults.Blank
        })
        { }
    }
}
