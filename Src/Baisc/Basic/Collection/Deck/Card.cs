﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Collection.Deck
{
    /// <summary>
    /// Card class
    /// </summary>
    public class Card
    {
        public readonly Suit suit;

        public readonly Rank rank;

        #region Consturct

        private Card()
        {
        }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        #endregion


        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }
    }
}
