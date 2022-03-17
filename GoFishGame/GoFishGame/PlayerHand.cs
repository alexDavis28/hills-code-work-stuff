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
                    Console.WriteLine($"{i + 1}: {rank_names[i]}");
                }
                requested_rank = int.Parse(Console.ReadLine());
                if (!HasCard(requested_rank))
                {
                    Console.WriteLine("You don't have a card of that rank");
                    requested_rank = -1;
                }
            }
            return requested_rank;
        }

        public override void FormBooks()
        {
            throw new NotImplementedException();
        }

    }
}
