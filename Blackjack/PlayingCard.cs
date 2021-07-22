using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class PlayingCard
    {
        public PlayingCard(int i)
        {
            int suit = i % 4;
            int rank = i % 13;

            this.Suit = PlayingCardSuit.GetSuitFromInt(suit);
            this.Rank = PlayingCardRank.GetRankFromInt(rank);

        }

        public string Rank { get; set; }
        public string Suit { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Rank}{Suit}");
        }
    }
}
