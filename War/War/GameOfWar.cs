using System;
using CardClasses;
using System.Linq;

namespace War
{   
    //NB uses System and CardClasses
    public class GameOfWar 
    {
        private Pack pack;
        private Hand[] hands;
        private Hand[] cards_in_play;
        private int players;

        public GameOfWar(int players)
        {
            //create the pack and hands
            this.players = players;
            if (players>4 || players<2)
            {
                throw new ArgumentException("Number of players must be between 2 and 4", nameof(players));
            }

            pack = new Pack();

            hands = new Hand[players];
            for (int i = 0; i < players; i++)
            {
                hands[i] = new Hand();
            }
            //shuffle the pack
            pack.Shuffle();
        }
        public void Deal()
        {
            while (!pack.IsEmpty() && pack.Size > 1) //Second evaluation handles for 3 players (52/3 == 17.33333)
            {
                for (int i = 0; i < players; i++)
                {
                    hands[i].AddCard(pack.DealCard());
                }
            }
        }
        public void Play()
        {
            cards_in_play = new Hand[players];
            for (int i = 0; i < players; i++)
            {
                cards_in_play[i] = new Hand();
            }
            Random random = new Random();
            bool playing = true;
            bool same_cards;

            for (int i = 0; i < hands.Length; i++)
            {
                Console.WriteLine($"Player {i} has {hands[i].Size} cards");
            }

            // while both players still have cards left in their hands
            while (playing)
            {
                do
                {

                    for (int i = 0; i < players; i++)
                    {
                        cards_in_play[i].AddCard(hands[i].RemoveFirstCard());
                        Console.WriteLine($"Player {i}: {cards_in_play[i].Last().GetName()}");
                    }
                    //!!!! while the last pair of cards put down are the same rank

                    // check if all cards are same rank
                    same_cards = false;
                    for (int i = 0; i < cards_in_play.Length-1; i++)
                    {
                        same_cards = (cards_in_play[i].Last().GetRank() == cards_in_play[i + 1].Last().GetRank());
                    }

                } while (same_cards);

                // Find highest ranked card and the player who put it down
                int[] ranks = new int[players];
                for (int i = 0; i < players; i++)
                {
                    ranks[i] = cards_in_play[i].Last().GetRank();
                }
                int highest_rank_value = ranks.Max();
                int highest_rank_index = ranks.ToList().IndexOf(highest_rank_value);

                // Give the winning player all the cards to the winning player
                Console.WriteLine($"Player {highest_rank_index} wins!");
                foreach (Hand hand in cards_in_play)
                {
                    while (hand.Size>0)
                    {
                        hands[highest_rank_index].AddCard(hand.RemoveFirstCard());
                    }
                }

                for (int i = 0; i < hands.Length; i++)
                {
                    Console.WriteLine($"Player {i} has {hands[i].Size} cards");
                }

                for (int i = 0; i < hands.Length; i++)
                {
                    if (hands[i].Size>=(52/players * 2))
                    {
                        Console.WriteLine($"Player {i} wins!");
                        playing = false;
                    }
                    else if (hands[i].Size<1)
                    {
                        playing = false;
                    }
                }
            }
        }

    }
}
