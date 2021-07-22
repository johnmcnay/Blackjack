using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            PlayingCard card = new PlayingCard { Rank = "A", Suit = PlayingCardSuit.Hearts };
            BlackjackDealer dealer = new BlackjackDealer();

            card.Display();
        }
    }
}
