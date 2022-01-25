using System;

namespace CardClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int s = 0; s < 4; s++)
            {
                for (int r = 1; r < 14; r++)
                {
                    Card card = new Card(r, s);
                    Console.WriteLine($"{card.rankAsString()} of {card.suitAsString()}: {card.getScore()}");
                }
            }
        }
    }
}
