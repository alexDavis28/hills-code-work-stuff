using System;

namespace War
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of players: ");
            int players = int.Parse(Console.ReadLine());
            GameOfWar game = new GameOfWar(players);
            game.Deal();
            game.Play();
            Console.ReadLine();
        }
    }
}
