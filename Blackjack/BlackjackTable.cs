using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class BlackjackTable
    {

        public List<BlackjackSeat> seats = new List<BlackjackSeat>();
        public BlackjackDealer dealer = new BlackjackDealer();

        public BlackjackTable()
        {
            seats.Add(new BlackjackPlayer());
        }

        public void DealRound()
        {

            foreach (var seat in seats)
            {
                seat.hand.PlayingCards.Add(dealer.deck.DrawOne());
                seat.hand.PlayingCards.Add(dealer.deck.DrawOne());
            }

            dealer.DealSelf();
        }
    }
}
