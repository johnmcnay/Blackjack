using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class BlackjackTable
    {

        public BlackjackPlayer Player = new BlackjackPlayer();
        public BlackjackDealer Dealer = new BlackjackDealer();

        public bool PlayerAction()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You have ${Player.Money}\n");
            Console.ResetColor();

            DisplayHands();
            
            string input;

            do
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Hit or stay?");
                    Console.ResetColor();
                    input = Console.ReadLine();

                } while (String.IsNullOrWhiteSpace(input));

                if (input.ToLower() == "hit")
                {
                    Player.hand.PlayingCards.Add(Dealer.deck.DrawOneFaceUp());

                    DisplayHands();

                    if (Player.hand.BlackjackValue() > 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have busted!");
                        Console.ResetColor();
                        Player.Money -= 5;
                        return false;
                    }
                }

            } while (input.ToLower() != "stay");

            return true;
        }

        public bool CheckForNaturalBlackjack()
        {
            int playerHandValue = Player.hand.BlackjackValue();
            int dealerHandValue = Dealer.hand.BlackjackValue();

            if (playerHandValue == 21)
            {
                DisplayHands();
                if (dealerHandValue == 21)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Tough luck. Both you and the dealer hit Blackjack. It's a push!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Blackjack! You win.");
                    Console.ResetColor();
                    Player.Money += 7.5;
                }
                return false;
            }
            else if (dealerHandValue == 21)
            {
                Dealer.hand.FlipAllToFaceUp();
                
                DisplayHands();
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dealer gets a Blackjack. You lose!");
                Console.ResetColor();
                
                Player.Money -= 5;
                
                return false;
            }

            return true;
        }

        public void PrepareForNewRound()
        {
            Player.DiscardAllCards();
            Dealer.DiscardAllCards();
            Dealer.deck = new PlayingCardDeck();
        }

        public void DealerAction()
        {
            Dealer.hand.FlipAllToFaceUp();

            //dealer's turn
            while (Dealer.hand.BlackjackValue() < 17)
            {
                Dealer.hand.PlayingCards.Add(Dealer.deck.DrawOneFaceUp());
            }
            DisplayHands();

            if (Dealer.hand.BlackjackValue() > 21)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"The dealer has busted with a {Dealer.hand.BlackjackValue()}! You win.");
                Console.ResetColor();
                Player.Money += 5;
            }
            else
            {
                if (Dealer.hand.BlackjackValue() > Player.hand.BlackjackValue())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You lose against {Dealer.hand.BlackjackValue()}!");
                    Console.ResetColor();
                    Player.Money -= 5;
                }
                else if (Dealer.hand.BlackjackValue() < Player.hand.BlackjackValue())
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"You win against {Dealer.hand.BlackjackValue()}!");
                    Console.ResetColor();
                    Player.Money += 5;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("It's a push!");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("");
        }

        public void DealRound()
        {
            Player.hand.PlayingCards.Add(Dealer.deck.DrawOneFaceUp());
            Player.hand.PlayingCards.Add(Dealer.deck.DrawOneFaceUp());
            Dealer.DealSelf();
        }

        public void DisplayHands()
        {
            string output = "The dealer has ";

            foreach (var card in Dealer.hand.PlayingCards)
            {
                output += $"{card.OutputString()} ";
            }

            Console.WriteLine(output);

            output = "You have ";

            //coded for a single player
            foreach (var card in Player.hand.PlayingCards)
            {
                output += $"{card.OutputString()} ";
            }

            output += $"Value: {Player.hand.BlackjackValue()}";

            Console.WriteLine(output);
        }
    }
}
