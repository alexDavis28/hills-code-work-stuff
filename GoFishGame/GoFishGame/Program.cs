using System;
using CardClasses;

namespace GoFishGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GoFish game = new GoFish(0, 4);
            game.Deal();
            game.Play();
        }
    }
}
