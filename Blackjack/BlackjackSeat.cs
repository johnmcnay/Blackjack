using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class BlackjackSeat
    {
        public BlackjackHand hand = new BlackjackHand();

        public void DiscardAllCards()
        {
            hand = new BlackjackHand();
        }
    }
}
