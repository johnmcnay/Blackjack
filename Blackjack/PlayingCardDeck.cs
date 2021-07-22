using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   
    class PlayingCardDeck : PlayingCardPile
    {        
        public PlayingCardDeck()
        {
            CreateDeck();
            Shuffle();
        }

        private void CreateDeck()
        {
            this.PlayingCards = new List<PlayingCard>();

            for (int i = 0; i < 52; i ++)
            {
                this.PlayingCards.Add(new PlayingCard(i));
            }
        }
    }
}
