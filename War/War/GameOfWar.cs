using System;
using CardClasses;

namespace War
{   
    //NB uses System and CardClasses
    public class GameOfWar 
    {
        private Pack pack;
        private Hand p1Hand, p2Hand;

        public GameOfWar()
        {
            //!!!!
            //create the pack and hands
            pack = new Pack();
            p1Hand = new Hand();
            p2Hand = new Hand();
            //shuffle the pack
            pack.Shuffle();
        }

        public void Deal()
        {
            while (!pack.IsEmpty())
            {
                p1Hand.AddCard(pack.DealCard());
                // do the same for p2Hand
                p2Hand.AddCard(pack.DealCard());
            }
        }

        public void Play()
        {
            Hand p1CardsInPlay = new Hand();
            Hand p2CardsInPlay = new Hand();
            Random random = new Random();
            // while both players still have cards left in their hands
            while (p1Hand.Size > 0 && p2Hand.Size > 0)
            {
                do
                {
                    p1CardsInPlay.AddCard(p1Hand.RemoveFirstCard());
                    p2CardsInPlay.AddCard(p2Hand.RemoveFirstCard());
                    Console.WriteLine(p1CardsInPlay.Last().GetName() + " " + p2CardsInPlay.Last().GetName());
                    //!!!! while the last pair of cards put down are the same rank
                } while (p1CardsInPlay.Last().GetRank() == p2CardsInPlay.Last().GetRank());

                //!!!! if Player1's card is higher than Player2's card
                if (p1CardsInPlay.Last().GetRank() > p2CardsInPlay.Last().GetRank())
                {
                    Console.WriteLine("Player 1 wins");
                    while (!p1CardsInPlay.IsEmpty())
                    {
                        p1Hand.AddCard(p1CardsInPlay.RemoveFirstCard());
                        p1Hand.AddCard(p2CardsInPlay.RemoveFirstCard());
                    }
                }
                // same but for player two
                else if (p1CardsInPlay.Last().GetRank() < p2CardsInPlay.Last().GetRank())
                {
                    Console.WriteLine("Player 2 wins");
                    while (!p2CardsInPlay.IsEmpty())
                    {
                        p2Hand.AddCard(p1CardsInPlay.RemoveFirstCard());
                        p2Hand.AddCard(p2CardsInPlay.RemoveFirstCard());
                    }
                }
                Console.WriteLine("Player 1 has " + p1Hand.Size + " cards");
                Console.WriteLine("Player 2 has " + p2Hand.Size + " cards\n");
            }
        }

    }
}
