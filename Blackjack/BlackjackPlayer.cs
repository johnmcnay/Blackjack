using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class BlackjackPlayer : BlackjackSeat
    {

        public double Money { get; set; }

        public BlackjackPlayer()
        {
            Money = 100d;
        }
       
    }
}
