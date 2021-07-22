using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class PlayingCard
    {
        public string Rank { get; set; }
        public string Suit { get; set; }
        public bool IsFaceUp { get; set; }

        public PlayingCard(int i)
        {
            int suit = i % 4;
            int rank = i % 13;

            this.Suit = PlayingCardSuit.GetSuitFromInt(suit);
            this.Rank = PlayingCardRank.GetRankFromInt(rank);
        }

        public int GetBlackjackValue()
        {

            if (int.TryParse(this.Rank, out var parsed) == false)
            {
                if (this.Rank == "A")
                {
                    return 11;
                }
                else
                {
                    return 10;
                }
            }

            return parsed;
        }

        public string OutputString()
        {
            if (this.IsFaceUp == false)
            {
                return "??";
            }

            return $"{(Rank == "T" ? "10" : Rank)}{Suit}";
        }
    }
}
