using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            do
            {
                BlackjackTable blackjack = new BlackjackTable();
                blackjack.DealRound();
                blackjack.DisplayHands();
                blackjack.PlayersDecide();
                Console.WriteLine("Press enter to play again or type exit");
            } while (Console.ReadLine().ToLower() != "exit");
            
        }
    }
}
