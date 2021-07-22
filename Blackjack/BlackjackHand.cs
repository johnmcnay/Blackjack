using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class BlackjackHand : PlayingCardPile
    {
        public int BlackjackValue()
        {
            int value = 0;
            int aces = 0;

            foreach (var card in this.PlayingCards)
            {
                if (card.GetBlackjackValue() == 11)
                {
                    aces++;
                }
                else
                {
                    value += card.GetBlackjackValue();
                }                
            }

            while (aces > 0)
            {
                if (value + 11 > 21)
                {
                    value += 1;
                } else
                {
                    value += 11;
                }

                aces--;
            }

            return value;
        }
    }
}
