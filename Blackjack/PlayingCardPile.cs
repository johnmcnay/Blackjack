using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class PlayingCardPile
    {
        public List<PlayingCard> PlayingCards = new List<PlayingCard>();

        public void Shuffle()
        {

        }

        public PlayingCard DrawOne()
        {
            PlayingCard card = this.PlayingCards[0];
            this.PlayingCards.RemoveAt(0);

            return card;
        }


    }
}
