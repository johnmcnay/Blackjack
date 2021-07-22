using System;
using System.Collections.Generic;

namespace Blackjack
{
    class PlayingCardPile
    {
        public List<PlayingCard> PlayingCards = new List<PlayingCard>();

        public void Shuffle()
        {
            List<PlayingCard> shuffled = new List<PlayingCard>();

            while (PlayingCards.Count > 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(PlayingCards.Count);
                shuffled.Add(PlayingCards[index]);
                PlayingCards.RemoveAt(index);
            }
            PlayingCards = shuffled;
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
