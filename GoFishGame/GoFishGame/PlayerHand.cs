using System;
using System.Collections.Generic;
using System.Text;

namespace CardClasses
{
    class PlayerHand : GoFishHand
    {
        public PlayerHand()
        {
            HandType = "Player";
        }

        public override int RequestCard()
        {
            string[] rank_names = { "Ace", "Two", "Three", "Four", "Five",
              "Six","Seven", "Eight", "Nine", "Ten",
              "Jack","Queen", "King" };
            int requested_rank = -1;
            while (requested_rank == -1)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("What card rank would you like to request? Enter the number");

                for (int i = 0; i < rank_names.Length; i++)
                {
                    if (HasCard(i+1))
                    {
                        Console.WriteLine($"{i + 1}: {rank_names[i]}");
                    }
                }
                bool valid_rank = int.TryParse(Console.ReadLine(), out requested_rank);
                if (!HasCard(requested_rank) || !valid_rank)
                {
                    Console.WriteLine("You don't have a card of that rank");
                    requested_rank = -1;
                }
            }
            return requested_rank;
        }
    }
}
