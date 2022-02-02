using System;

namespace SimpleCardGameV2._0
{
    class Program
    {
        static Pack pack;
        static Card[] player1Hand;
        static Card[] player2Hand;

        static void Main(string[] args)
        {
            Game game = new Game();
            game.Deal();
            game.Play();
        }
    }
}
