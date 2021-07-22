using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public static class PlayingCardSuit
    {
        private const string _HEARTS = "\u2661";
        private const string _SPADES = "\u2664";
        private const string _CLUBS = "\u2667";
        private const string _DIAMONDS = "\u2662";
        private const string _SUITS = "\u2661\u2664\u2667\u2662";

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
