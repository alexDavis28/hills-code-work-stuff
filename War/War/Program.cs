using System;

namespace War
{
    class Program
    {
        static void Main(string[] args)
        {
            GameOfWar game = new GameOfWar();
            game.Deal();
            game.Play();
            Console.ReadLine();
        }
    }
}
