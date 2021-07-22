using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    


    class PlayingCardDeck
    {
 
        public List<PlayingCard> PlayingCards { get; set; }
        
        public PlayingCardDeck()
        {
            CreateDeck();

            return;
        }

        private void CreateDeck()
        {
            this.PlayingCards = new List<PlayingCard>();

            for (int i = 0; i < 52; i ++)
            {
                this.PlayingCards.Add(i);
            }

        }
    }
}
