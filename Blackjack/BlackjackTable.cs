using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class BlackjackTable
    {

        public List<BlackjackSeat> seats = new List<BlackjackSeat>();
        public BlackjackDealer dealer = new BlackjackDealer();

        public BlackjackTable()
        {
            seats.Add(new BlackjackPlayer());
        }

        public void PlayersDecide()
        {
            string input;

            do
            {
                do
                {
                    Console.WriteLine("Would you like to hit or stay?");
                    input = Console.ReadLine();


                } while (String.IsNullOrWhiteSpace(input));

                if (input.ToLower() == "hit")
                {
                    seats[0].hand.PlayingCards.Add(dealer.deck.DrawOneFaceUp());

                    DisplayHands();

                    //if bust
                    if (seats[0].hand.BlackjackValue() > 21)
                    {
                        Console.WriteLine("You have busted!");
                        return;
                    }
                }

            } while (input.ToLower() != "stay");

            //dealer's turn
            
        }

        public void DealRound()
        {

            foreach (var seat in seats)
            {
                seat.hand.PlayingCards.Add(dealer.deck.DrawOneFaceUp());
                seat.hand.PlayingCards.Add(dealer.deck.DrawOneFaceUp());
            }

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
            foreach (var card in seats[0].hand.PlayingCards)
            {
                output += $"{card.OutputString()} ";
            }

            output += $"Value: {seats[0].hand.BlackjackValue()}";

            Console.WriteLine(output);
        }
    }
}
