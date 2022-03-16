using System;
using CardClasses;

namespace GoFishGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GoFish game = new GoFish(2, 0);
            game.Deal();
            game.Play();
        }
    }
}
