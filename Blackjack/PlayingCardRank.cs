using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class PlayingCardRank
    {
        private const string _RANKS = "A23456789TJQK";
        public string Rank { get; set; }

        public static string GetRankFromInt(int rank)
        {
            return _RANKS.Substring(rank, 1);
        }
    }
}
