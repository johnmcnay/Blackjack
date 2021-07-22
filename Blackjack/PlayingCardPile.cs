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

        private PlayingCard DrawOne()
        {
            PlayingCard card = this.PlayingCards[0];
            this.PlayingCards.RemoveAt(0);

            return card;
        }
        
        public PlayingCard DrawOneFaceUp()
        {
            PlayingCard card = DrawOne();
            card.IsFaceUp = true;
            return card;
        }

        public PlayingCard DrawOneFaceDown()
        {
            PlayingCard card = DrawOne();
            card.IsFaceUp = false;
            return card;
        }


    }
}
