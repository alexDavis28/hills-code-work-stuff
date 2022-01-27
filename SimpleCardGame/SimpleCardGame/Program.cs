using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace SimpleCardGame
{
    class Program
    {
        static Card[] pack = new Card[52];
        // declare two arrays for player1 hand and player2 hand

        static Card[] hand_1 = new Card[26];
        static Card[] hand_2 = new Card[26];

        static void CreateAndShuffle()
        {
            Random rnd = new Random();

            for (int i = 0; i < pack.Length; i++)
            {
                pack[i] = new Card(i % 13 + 1, i / 13);
            }

            //Fisher-Yates shuffle
            for (int i = 0; i < pack.Length - 1; i++)
            {
                int r = rnd.Next(i + 1, 52);
                Card temp = pack[i];
                pack[i] = pack[r];
                pack[r] = temp;
            }
        }

        static void Deal()
        {
            for (int i = 0; i < 26; i++)
            {
                // assign card from pack to player1 hand
                hand_1[i] = pack[i];
                // assign card from pack to player2 hand
                hand_2[i] = pack[i + 26];
            }
        }

        static void Play()
        {
            int score1 = 0;
            int score2 = 0;
            for (int i = 0; i < 26; i++)
            {
                // your algorithm

                Console.Clear();

                Card card_1 = hand_1[i];
                Card card_2 = hand_2[i];

                Console.WriteLine("NEW ROUND\n");
                Console.WriteLine($"Current scores\nPlayer 1: {score1}\nPlayer 2: {score2}\n\n");
                Console.WriteLine("Player 1 card: " + card_1.GetName()+ " - rank: " + card_1.GetRank());
                Console.WriteLine("Player 2 card: " + card_2.GetName() + " - rank: " + card_2.GetRank());

                if (card_1.GetRank() > card_2.GetRank())
                {
                    Console.WriteLine("Player 1 wins this round!");
                    score1++;
                }
                else if (card_1.GetRank() < card_2.GetRank())
                {
                    Console.WriteLine("Player 2 wins this round!");
                    score2++;
                }
                else
                {
                    if (card_1.GetSuit() > card_2.GetSuit())
                    {
                        Console.WriteLine("Player 1 wins this round!");
                        score1++;
                    }
                    else if (card_1.GetSuit() < card_2.GetSuit())
                    {
                        Console.WriteLine("Player 2 wins this round!");
                        score2++;
                    }
                }
                Console.WriteLine("\nPress enter to start next round");
                Console.ReadLine();
            }
            
            Console.Clear();
            Console.WriteLine("GAME END\n");
            Console.WriteLine($"Current scores\nPlayer 1: {score1}\nPlayer 2: {score2}\n\n");

            if (score1>score2)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else if (score1<score2)
            {
                Console.WriteLine("Player 2 wins!");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            CreateAndShuffle();
            Deal();
            Play();
        }
    }
}