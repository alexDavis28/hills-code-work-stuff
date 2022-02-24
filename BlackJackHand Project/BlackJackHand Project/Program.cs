using System;
using CardClasses;

namespace BlackJackHand_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            BlackJackHand hand = new BlackJackHand();
            for (int i = 0; i < 2; i++)
            {
                Card card = new Card(random.Next(1, 14), random.Next(4));
                hand.AddCard(card);
            }
            hand.DisplayCards();
            Console.WriteLine("Score:" + hand.GetScore());
        }
    }
}
