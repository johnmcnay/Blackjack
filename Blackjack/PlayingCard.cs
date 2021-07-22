using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class PlayingCard
    {
        public PlayingCard(int i)
        {
            int suit = i % 4;

            switch (suit)
            {
                case 0:
                    this.Suit = PlayingCardSuit.Clubs;
                    break;
                case 1:
                    this.Suit = PlayingCardSuit.Spades;
                    break;
                case 2:
                    this.Suit = PlayingCardSuit.Hearts;
                    break;
                case 3:
                    this.Suit = PlayingCardSuit.Diamonds;
                    break;
            }

        }

        public string Rank { get; set; }
        public string Suit { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Rank}{Suit}");
        }
    }
}
