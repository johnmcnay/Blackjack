using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class BlackjackDealer : BlackjackSeat
    {
        public PlayingCardDeck deck = new PlayingCardDeck();

        public void Shuffle()
        {
            this.deck.Shuffle();
        }

        public void DealAllSeats()
        {
            
        }

        public void DealSelf()
        {
            hand.PlayingCards.Add(deck.DrawOne());
            hand.PlayingCards.Add(deck.DrawOne());
        }
    }
}
