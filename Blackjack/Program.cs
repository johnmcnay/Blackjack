using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BlackjackTable blackjack = new BlackjackTable();

            blackjack.DealRound();

            return;
        }
    }
}
