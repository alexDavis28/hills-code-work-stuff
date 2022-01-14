using System;

namespace CardClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Card card = new Card(rand.Next(12)+1, rand.Next(0, 4));
            Console.WriteLine(card.getRank());
            Console.WriteLine(card.getSuit());
            Console.WriteLine(card.getScore());
        }
    }
}
