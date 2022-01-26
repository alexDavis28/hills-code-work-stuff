using System;

namespace CardClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Card[] pack = new Card[52];

            for (int i = 0; i < pack.Length; i++)
            {
                int r = (i % 13)+1;
                int s = i / 13;
                Card card = new Card(r, s);
                Console.WriteLine($"{card.rankAsString()} of {card.suitAsString()}: {card.getScore()}");
            }
        }
    }
}
