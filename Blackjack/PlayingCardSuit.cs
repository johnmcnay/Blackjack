using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public static class PlayingCardSuit
    {
        private const string _HEARTS = "H";
        private const string _SPADES = "S";
        private const string _CLUBS = "C";
        private const string _DIAMONDS = "D";
        private const string _SUITS = "HSCD";

        public static string Hearts { get { return _HEARTS; } }
        public static string Spades { get { return _SPADES; } }
        public static string Clubs { get { return _CLUBS; } }
        public static string Diamonds { get { return _DIAMONDS; } }

        public static string GetSuitFromInt(int suit)
        {
            return _SUITS.Substring(suit, 1);
        }

    }
}
