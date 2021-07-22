using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class BlackjackTable
    {

        public BlackjackPlayer player = new BlackjackPlayer();
        public BlackjackDealer dealer = new BlackjackDealer();

        public void PlayersDecide()
        {
            string input;

            do
            {
                do
                {
                    Console.WriteLine("Hit or stay?");
                    input = Console.ReadLine();

                } while (String.IsNullOrWhiteSpace(input));

                if (input.ToLower() == "hit")
                {
                    player.hand.PlayingCards.Add(dealer.deck.DrawOneFaceUp());

                    DisplayHands();

                    //if bust
                    if (player.hand.BlackjackValue() > 21)
                    {
                        Console.WriteLine("You have busted!");
                        return;
                    }
                }

            } while (input.ToLower() != "stay");

            var faceDownCards = (from c in dealer.hand.PlayingCards
                                 where c.IsFaceUp == false
                                 select c).ToList();

            foreach (var card in faceDownCards)
            {
                card.IsFaceUp = true;
            }

            //dealer's turn
            while (dealer.hand.BlackjackValue() < 17)
            {
                dealer.hand.PlayingCards.Add(dealer.deck.DrawOneFaceUp());
            }
            DisplayHands();

            if (dealer.hand.BlackjackValue() > 21)
            {
                Console.WriteLine($"The dealer has busted with a {dealer.hand.BlackjackValue()}!");
            } else
            {
                if (dealer.hand.BlackjackValue() > player.hand.BlackjackValue())
                {
                    Console.WriteLine($"You lose against {dealer.hand.BlackjackValue()}!");
                } 
                else if (dealer.hand.BlackjackValue() < player.hand.BlackjackValue()) 
                {
                    Console.WriteLine($"You win against {dealer.hand.BlackjackValue()}!");
                }
                else
                {
                    Console.WriteLine("It's a push!");
                }
            }
        }

        public void DealRound()
        {
            player.hand.PlayingCards.Add(dealer.deck.DrawOneFaceUp());
            player.hand.PlayingCards.Add(dealer.deck.DrawOneFaceUp());

            dealer.DealSelf();
        }

        public void DisplayHands()
        {
            string output = "The dealer has ";

            foreach (var card in dealer.hand.PlayingCards)
            {
                output += $"{card.OutputString()} ";
            }

            Console.WriteLine(output);

            output = "You have ";

            //coded for a single player
            foreach (var card in player.hand.PlayingCards)
            {
                output += $"{card.OutputString()} ";
            }

            output += $"Value: {player.hand.BlackjackValue()}";

            Console.WriteLine(output);
        }
    }
}
