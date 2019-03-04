using System;
using System.Collections.Generic;

namespace DiceSimulator.Dice
{
    public abstract class BaseDie : IDie
    {
        private Random _rng;
        private IList<DieResult> _sides;

        public int NumSides
        {
            get { return _sides.Count; }
        }

        public BaseDie(Random rng, IList<DieResult> sides)
        {
            _rng = rng;
            _sides = sides;
        }

        public DieResult Roll()
        {
           return _sides[_rng.Next(_sides.Count)];
        }
    }
}
