using System;
using System.Collections.Generic;
using System.Text;

namespace CardClasses
{
    class GoFish
    {

        private Pack pack = new Pack();
        private int NumHands;
        private GoFishHand[] hands;

        public GoFish(int NumPlayers, int NumComputers)
        {
            NumHands = NumPlayers + NumComputers; // total number of player and ai hands

            if (NumHands<2)
            {
                throw new ArgumentException("Number of total players must be greater than 1");
            }

            hands = new GoFishHand[NumHands];

            // populate hands array
            for (int i = 0; i < NumPlayers; i++)
            {
                hands[i] = new PlayerHand();
            }
            for (int i = 0+NumPlayers; i < NumPlayers+NumComputers; i++)
            {
                hands[i] = new ComputerHand();
            }
        }

        public void Deal()
        {
            // shuffle and deal the cards
            pack.Shuffle();

            int CardsToDeal = 7;
            // If 2 player deal 7 cards each, otherwise deal 5
            if (NumHands>1 && NumHands<3)
            {
                CardsToDeal = 7;
            }
            else if (NumHands>=3)
            {
                CardsToDeal = 5;
            }

            for (int i = 0; i < NumHands; i++)
            {
                for (int j = 0; j < CardsToDeal; j++)
                {
                    hands[i].AddCard(pack.DealCard());
                }
            }
        }

        public void EvaluteBooks(GoFishHand hand)
        {
            hand.FormBooks();
            if (hand.BookCount > 0)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Books:");
                hand.DisplayBooks();
            }
        }

        public void Play()
        {

            string[] rank_names = { "Ace", "Two", "Three", "Four", "Five",
              "Six","Seven", "Eight", "Nine", "Ten",
              "Jack","Queen", "King" };

            bool playing = true;
            while (playing)
            {
                /*
                foreach (GoFishHand hand in hands)
                {
                    hand.DisplayCards();
                    Console.WriteLine("-------------");
                }
                Console.ReadLine();
                */

                bool taking_turn = true;
                for (int i = 0; i < hands.Length; i++) // iterate through each of the hands
                {

                    taking_turn = true;
                    GoFishHand hand = hands[i];



                    while (taking_turn) // if the current player makes a catch then this loop repeats
                    {
                        Console.Clear();
                        Console.WriteLine($"Player {i + 1}'s turn");
                        Console.WriteLine($"They have {hand.Size} cards, and {hand.BookCount} complete books.");
                        EvaluteBooks(hand);

                        if (hand.GetHandType() == "Player")
                        {
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine($"Player {i + 1}'s cards:");
                            hand.DisplayCards();
                            int requested_rank = hand.RequestCard(); // Get the player to choose a rank to request
                            GoFishHand next_player_hand = hands[(i + 1)%hands.Length]; // Check if next player has any cards of that rank
                            Console.WriteLine("--------------------------------------------");

                            if (next_player_hand.HasCard(requested_rank))
                            {
                                // take card(s) then loop turn
                                Console.WriteLine("The next player had the card(s)!");
                                for (int j = 0; j < next_player_hand.Size; j++) // Loop through the next player's hand
                                {
                                    if (next_player_hand[j].GetRank() == requested_rank)
                                    {
                                        // Any card that is of the rank that is requested is removed from the next player's hand and given to the active player
                                        Card taken_card = next_player_hand.RemoveCard(j);
                                        hand.AddCard(taken_card);
                                        Console.WriteLine($"Player {i + 1} took a {taken_card.GetName()}");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Go Fish!");
                                Card card_drawn = pack.DealCard();
                                hand.AddCard(card_drawn);
                                Console.WriteLine($"Player {i + 1} drew a {card_drawn.GetName()}");
                                if (card_drawn.GetRank() == requested_rank)
                                {
                                    Console.WriteLine($"Player {i + 1} made a catch!");
                                }
                                else
                                {
                                    taking_turn = false; // If they don't make a catch, the loop ends and the next player takes their turn
                                }
                            }
                        }
                        else if (hand.GetHandType() == "Computer")
                        {
                            int requested_rank = hand.RequestCard(); // computer randomly selects a rank to request
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine($"Player {i+1} requests a {rank_names[requested_rank-1]}");
                            GoFishHand next_player_hand = hands[(i + 1) % hands.Length];
                            if (next_player_hand.HasCard(requested_rank)) // check if next player has the card
                            {
                                // take card(s) then loop turn
                                Console.WriteLine("The next player had the card(s)!");
                                for (int j = 0; j < next_player_hand.Size; j++)
                                {
                                    if (next_player_hand[j].GetRank() == requested_rank)
                                    {
                                        Card taken_card = next_player_hand.RemoveCard(j);
                                        hand.AddCard(taken_card);
                                        Console.WriteLine($"Player {i + 1} took a {taken_card.GetName()}");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Go Fish!");
                                Card card_drawn = pack.DealCard();
                                Console.WriteLine(pack.Size);
                                if (card_drawn != null)
                                {
                                    Console.WriteLine($"Player {i + 1} drew a {card_drawn.GetName()}");
                                    hand.AddCard(card_drawn);
                                    if (card_drawn.GetRank() == requested_rank)
                                    {
                                        Console.WriteLine($"Player {i + 1} made a catch!");
                                    }
                                    else
                                    {
                                        taking_turn = false;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No cards left in deck, game ends");
                                    taking_turn = false;
                                    playing = false;
                                    break;
                                }
                            }
                        }
                        Console.WriteLine("Press enter to end the current turn");
                        Console.ReadLine();
                    }
                    EvaluteBooks(hand);
                }
            }
        }
    }
}
