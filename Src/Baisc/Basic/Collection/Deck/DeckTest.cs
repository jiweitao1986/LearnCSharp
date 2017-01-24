using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Collection.Deck
{
    public static class DeckTest
    {
        public static void Run()
        {
            Deck deck = new Deck();
            deck.Shuffle();
            for (int i = 1; i <= 51; i++)
            {
                var card = deck.GetCard(i);
                Console.WriteLine("Suit:" + card.suit.ToString() + ", Rank:" + card.rank.ToString());
            }

        }
    }
}
