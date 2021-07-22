using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BlackjackTable blackjack = new BlackjackTable();

            do
            {
                blackjack.DealRound();
                
                if (blackjack.CheckForNaturalBlackjack())
                {
                    if (blackjack.PlayerAction())
                    {
                        blackjack.DealerAction();
                    }
                }
                
                blackjack.PrepareForNewRound();

                Console.WriteLine("Press enter to play again or type exit");
            } while (Console.ReadLine().ToLower() != "exit");
            
        }
    }
}
