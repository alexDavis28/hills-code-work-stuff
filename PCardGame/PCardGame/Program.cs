using System;

namespace PCardGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string rank = "";
            string suit = "";

            // "seeds" (initialises) the random number generator
            Random random = new Random();

            //selects a random number between 0 and 51,
            //adds one to it and assigns the result to number
            int number = random.Next(52) + 1;

            // ???  complete this using the method you came up with in your triangles

            number--;

            // Range of card numbers is 0 to 51
            // 13 cards to a suit, card 0 in a suit is the Ace

            int ranknum = number % 13;
            int suitnum = number / 13;

            // ??? complete this case statement for the other ranks
            switch (ranknum + 1)
            {
                case 1:
                    rank = "Ace";
                    break;
                case 2:
                    rank = "Two";
                    break;
                case 3:
                    rank = "Three";
                    break;
                case 4:
                    rank = "Four";
                    break;
                case 5:
                    rank = "Five";
                    break;
                case 6:
                    rank = "Six";
                    break;
                case 7:
                    rank = "Seven";
                    break;
                case 8:
                    rank = "Eight";
                    break;
                case 9:
                    rank = "Nine";
                    break;
                case 10:
                    rank = "Ten";
                    break;
                case 11:
                    rank = "Jack";
                    break;
                case 12:
                    rank = "Queen";
                    break;
                case 13:
                    rank = "King";
                    break;
            }

            // add if statements for the other suits
            if (suitnum == 0)
            {
                suit = "Clubs";
            }
            else if (suitnum == 1)
            {
                suit = "Spades";
            }
            else if (suitnum == 2)
            {
                suit = "Hearts";
            }
            else
            {
                suit = "Diamonds";
            }

            Console.WriteLine("Your card is the " + rank + " of " + suit);
            Console.ReadLine();

        }
    }


}
