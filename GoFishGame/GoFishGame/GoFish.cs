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

            // populate hands array with "players"
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
            pack.Shuffle();

            // If 2 players deal 7 cards each, otherwise deal 5
            int CardsToDeal = 7;
            if (NumHands>=3)
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
            // Try to f rm books from cards in hand, then display those books
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
            while (playing) // main loop of game
            {
                bool taking_turn;
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

                        if (hand.GetHandType() == "Player") // only show cards if it's the turn of a human player
                        {
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine($"Player {i + 1}'s cards:");
                            hand.DisplayCards();
                        }
                        // If the hand belongs to a human player it will ask them to enter a rank to request, but if it's an "ai" it will randomly select a rank
                        int requested_rank = hand.RequestCard();
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine($"Player {i + 1} requests a {rank_names[requested_rank - 1]}");

                        GoFishHand next_player_hand = hands[(i + 1) % hands.Length]; // Check if next player has any cards of that rank

                        if (next_player_hand.HasCard(requested_rank)) // check if next player has the card
                        {
                            // take all the cards that the other player has of the rank requested
                            Console.WriteLine("The next player had the card(s)!");
                            for (int j = 0; j < next_player_hand.Size; j++) // should this be done backwards to avoid index issues?
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
                            if (card_drawn != null) // card_drawn is null if the pack is empty
                            {
                                Console.WriteLine($"Player {i + 1} drew a {card_drawn.GetName()}");
                                hand.AddCard(card_drawn);
                                if (card_drawn.GetRank() == requested_rank)
                                {
                                    Console.WriteLine($"Player {i + 1} made a catch!");
                                }
                                else
                                {
                                    taking_turn = false; // end current player's turn if they don't make a catch
                                }
                            }
                            else
                            {
                                // Game ends if someone needs to draw and there are no cards left in the pack
                                Console.WriteLine("No cards left in deck, game finishes.\nPress enter to end game");
                                Console.ReadLine();
                                taking_turn = false;
                                playing = false;
                                EndGame();
                            }
                        }

                        // If new books are formed, display the books
                        int book_count = hand.BookCount;
                        hand.FormBooks();
                        if (hand.BookCount > book_count)
                        {
                            EvaluteBooks(hand);
                        }

                        if (hand.Size==0) // fix for issue of forming a book leaving no cards left in hand
                        {
                            Console.WriteLine($"Player {i + 1} has no cards remaining, so draws a new card");
                            Card card_drawn = pack.DealCard();
                            if (card_drawn != null)
                            {
                                Console.WriteLine($"Player {i + 1} drew a {card_drawn.GetName()}");
                                hand.AddCard(card_drawn);
                            }
                            else
                            {
                                Console.WriteLine("No cards left in deck, game finishes.\nPress enter to end game");
                                Console.ReadLine();
                                taking_turn = false;
                                playing = false;
                                EndGame();
                            }
                        }

                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Press enter to end the current turn");
                        Console.ReadLine();
                    }
                }
            }
        }

        public void EndGame()
        {
            Console.Clear();
            // Display final scores
            Console.WriteLine("Final Scores:");
            for (int i = 0; i < hands.Length; i++)
            {
                Console.WriteLine($"Player {i+1}: {hands[i].BookCount} books");
            }

            // Find hand with highest number of books
            int winner_index = -1;
            int winner_book_count = 0;
            bool tie = false;

            for (int i = 0; i < hands.Length; i++)
            {
                if (hands[i].BookCount > winner_book_count)
                {
                    winner_index = i;
                    winner_book_count = hands[i].BookCount;
                }
            }

            int c = 0;
            for (int i = 0; i < hands.Length; i++)
            {
                if (hands[i].BookCount==winner_book_count)
                {
                    c++;
                }
            }
            tie = c > 1; // if the highest score appears more than once it's a tie

            if (tie)
            {
                Console.WriteLine("The game ends in a tie");
            }
            else
            {
                Console.WriteLine($"Player {winner_index+1} wins!");
            }

            Console.ReadLine();
            System.Environment.Exit(1);
        }
    }
}
