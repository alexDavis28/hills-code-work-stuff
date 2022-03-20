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
            // Allows the player to choose a rank to request from the ranks that already exist in their hand

            string[] rank_names = { "Ace", "Two", "Three", "Four", "Five",
              "Six","Seven", "Eight", "Nine", "Ten",
              "Jack","Queen", "King" };
            int requested_rank = -1;

            while (requested_rank == -1)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("What card rank would you like to request? Enter the number");

                for (int i = 0; i < rank_names.Length; i++) // For all ranks, if the rank exists in the player's hand show it as an option
                {
                    if (HasCard(i+1))
                    {
                        Console.WriteLine($"{i + 1}: {rank_names[i]}");
                    }
                }
                bool valid_rank = int.TryParse(Console.ReadLine(), out requested_rank); // make sure that the rank is inputted as an int
                if (!HasCard(requested_rank) || !valid_rank) // check that the player has a card of that rank and that the inputted value is a number
                {
                    Console.WriteLine("You don't have a card of that rank");
                    requested_rank = -1;
                }
            }
            return requested_rank;
        }
    }
}
