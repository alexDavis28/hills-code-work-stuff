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
            NumHands = NumPlayers + NumComputers;

            if (NumHands<2)
            {
                throw new ArgumentException("Number of total players must be greater than 1");
            }

            hands = new GoFishHand[NumHands];

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

            int CardsToDeal = 7; ;
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

        public void  Play()
        {

            string[] rank_names = { "Ace", "Two", "Three", "Four", "Five",
              "Six","Seven", "Eight", "Nine", "Ten",
              "Jack","Queen", "King" };

            bool playing = true;
            while (playing)
            {
                foreach (GoFishHand hand in hands)
                {
                    hand.DisplayCards();
                    Console.WriteLine("-------------");
                }
                Console.ReadLine();

                bool taking_turn = true;
                for (int i = 0; i < hands.Length; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Player {i + 1}'s turn");

                    taking_turn = true;
                    GoFishHand hand = hands[i];
                    while (taking_turn)
                    {
                        if (hand.GetHandType() == "Player")
                        {
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("These are your cards:");
                            hand.DisplayCards();
                            Console.WriteLine("--------------------------------------------");
                            int requested_rank = hand.RequestCard();
                            GoFishHand next_player_hand = hands[(i + 1)%hands.Length];
                            Console.WriteLine("--------------------------------------------");
                            if (next_player_hand.HasCard(requested_rank))
                            {
                                // take card(s) then loop turn
                                Console.WriteLine("The next player had the card(s)!");
                                for (int j = 0; j < next_player_hand.Size; j++)
                                {
                                    if (next_player_hand[j].GetRank() == requested_rank)
                                    {
                                        Card taken_card = next_player_hand.RemoveCard(j);
                                        hand.AddCard(taken_card);
                                        Console.WriteLine($"You took a {taken_card.GetName()}");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Go Fish!");
                                Card card_drawn = pack.DealCard();
                                hand.AddCard(card_drawn);
                                Console.WriteLine($"You drew a {card_drawn.GetName()}");
                                if (card_drawn.GetRank() == requested_rank)
                                {
                                    Console.WriteLine("You made a catch!");
                                }
                                else
                                {
                                    Console.WriteLine("Press enter to end your turn");
                                    Console.ReadLine();
                                    taking_turn = false;
                                }
                            }
                        }
                        else if (hand.GetHandType() == "Computer")
                        {
                            int requested_rank = hand.RequestCard();
                            Console.WriteLine($"Player {i+1} requests a {rank_names[requested_rank]}");
                            GoFishHand next_player_hand = hands[(i + 1) % hands.Length];
                            if (next_player_hand.HasCard(requested_rank))
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
                                Console.WriteLine($"Player {i + 1} drew a {card_drawn.GetName()}");
                                hand.AddCard(card_drawn);
                                if (card_drawn.GetRank() == requested_rank)
                                {
                                    Console.WriteLine("Player {i+1} made a catch!");
                                }
                                else
                                {
                                    Console.WriteLine($"Press enter to end Player {i+1}'s turn");
                                    Console.ReadLine();
                                    taking_turn = false;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
